#!/usr/bin/env python
import os
import glob
from sets import Set as sets
import yaml
import sys
import traceback

"""
Check that all translation have proper keys

This script can be used to check that all translations have the same set
of keys as the 'master' locale - English in our case.

Just run the script. No output is good.
"""

master = "en"
basedir = "%s/locales" % os.getcwd()

def compare_dicts(master, victim, path):
    if type(victim) != dict:
        return ["Victim %s is not a dictionary" % '.'.join(path)]

    master_keys = sets.Set(list(master.keys()))
    victim_keys = sets.Set(list(victim.keys()))

    errors = []
    missing_keys = master_keys - victim_keys
    if missing_keys:
        errors.append("%s is missing keys: %s" % ('.'.join(path), ', '.join(missing_keys)))

    extra_keys = victim_keys - master_keys
    if extra_keys:
        errors.append("%s has extra keys: %s" % ('.'.join(path), ', '.join(extra_keys)))

    for k in master_keys & victim_keys:
        subpath = path[:]
        subpath.append(k)
        type_master = type(master[k])
        type_victim = type(victim[k])
        if type_master == str:
            type_master = str
        if type_victim == str:
            type_victim = str
        if type_master != type_victim:
            errors.append("%s type is incorrect (%s, should be %s)" %
                    ('.'.join(subpath), type_victim, type_master))
        else:
            if type_master == dict:
                errors.extend(compare_dicts(master[k], victim[k], subpath))

    return errors

def process_file(filename, master_data):
    if filename == "%s.yml" % master: return
    with open(filename, 'r') as f:
        victim_lang = os.path.basename(filename).replace('.yml','')
        victim_data = yaml.load(f)
        if victim_lang in victim_data:
            errors = compare_dicts(master_data, victim_data[victim_lang], [])
        else:
            errors = ["Top-level node '%s' not found" % victim_lang]

        if errors:
            print("Errors found in %s:" % filename)
            for error in errors:
                print("- %s" % error)

            return errors

def main(args):
    exitcode = 0
    with open(os.path.join(basedir, "%s.yml" % master), 'r') as master_file:
        master_data = yaml.load(master_file)[master]

    if len(args) > 1:
        filenames = args[1:]
    else:
        filenames = glob.glob(os.path.join(basedir, '*.yml'))

    for filename in filenames:
        filename = os.path.join(basedir, filename)
        if not os.path.exists(filename):
            filename += '.yml'
        try:
            process_file(filename, master_data)
        except yaml.scanner.ScannerError:
            traceback.print_exc()
            exitcode = 1

    return exitcode
if __name__ == "__main__":
    sys.exit(main(sys.argv))
