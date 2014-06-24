namespace :i18n do
  desc "Invalidate locales one-by-one"
  task :invalidate do
    master = :en
    basedir = File.join(Dir.pwd, "locales")
    available = Dir.glob(File.join(basedir, "*.yml"))
    translations = available - [master]
    identation = "  " # ._.

    while true
      puts "Path to invalidate:"
      path = STDIN.gets.strip
      exit if %w(q quit exit).include?(path)

      confirm = []
      results = Hash.new
      translations.each do |translation|
        locale = File.basename(translation, ".yml")
        lines = File.read(translation).split("\n")
        result = Hash.new
        level = 0
        full_path = [locale] + path.split(".")

        lines.each_with_index do |text, line|
          next if text.empty? # Atom cleans up blank lines
          current_identation = "  "*level

          if !text.start_with?(current_identation)
            spaces = text[/^[\s]*/, 1]
            level = spaces ? spaces.split(identation).length : 0
            next
          end

          if text.start_with?(current_identation+full_path[level]+":")
            if level == full_path.length-1
              result[:lines] = [line]
              result[:texts] = [text]

              lines[line+1..-1].each_with_index do |child_text, child_line|
                if child_text.start_with?(current_identation+identation)
                  result[:lines] << line + child_line + 1
                  result[:texts] << child_text
                else
                  break
                end
              end

              break
            else
              level += 1
            end
          end
        end

        if result[:lines]
          multiline = result[:lines].length > 1
          result[:texts].map! { |x| x.gsub(/^[\s]{#{full_path.length}}/, "") }

          confirm << "#{locale}.yml:#{multiline ? "#{result[:lines].first+1}..#{result[:lines].last+1}" : result[:lines].first+1}"
          confirm << (multiline ? "\n#{result[:texts].join("\n")}\n\n" : " - #{result[:texts].first.strip}\n")
          results[translation] = result
        end
      end

      if confirm.any?
        puts confirm.join(""), "\n", "Confirm? y/n"
        if STDIN.gets.strip == "y"
          results.each do |translation, result|
            lines = File.read(translation).split("\n")
            result[:lines].each { |x| lines[x] = nil }
            File.open(translation, "w") { |f| f.write(lines.compact.join("\n")+"\n") }
          end

          puts "Done."
        end
        puts
      end
    end
  end
end
