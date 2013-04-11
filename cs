cs:
  # Devise
  errors:
    messages:
      expired: "has expired, please request a new one"
      not_found: "not found"
      already_confirmed: "was already confirmed, please try signing in"
      not_locked: "was not locked"
      not_saved:
        one: "1 error prohibited this %{resource} from being saved:"
        few: "%{count} errors prohibited this %{resource} from being saved:"
        many: "%{count} errors prohibited this %{resource} from being saved:"
        other: "%{count} errors prohibited this %{resource} from being saved:"
  
  devise:
    failure:
      already_authenticated: "You are already signed in."
      unauthenticated: "You need to sign in to continue."
      unconfirmed: "You have to confirm your account to continue."
      locked: "Your account is locked."
      invalid: "Neplatný e-mail nebo heslo."
      invalid_token: "Neplatný autentizační symbol."
      timeout: "Vaše relace vypršela,přihlašte se znova"
      inactive: "Váš účet nebyl aktivován."
    sessions:
      signed_in: "Úspěšné přihlášení."
      signed_out: "Úspěšně odhlášeni."
    passwords:
      send_instructions: "Během několika minut obdržíte email s pokyny o tom, jak obnovit své heslo."
      updated: "Vaše heslo bylo úspěšně změněno. Jste přihlášen."
      updated_not_active: "Vaše heslo bylo úspěšně změněno"
      send_paranoid_instructions: "Pokud váš email existuje v naší databázi, obdržíte email s odkazem pro obnovení hesla"
    confirmations:
      send_instructions: "You will receive an email with instructions about how to confirm your account in a few minutes."
      send_paranoid_instructions: "If your e-mail exists on our database, you will receive an email with instructions about how to confirm your account in a few minutes."
      confirmed: "Your account was successfully confirmed. You are now signed in."
    registrations:
      signed_up: "Welcome! You have signed up successfully."
      signed_up_but_unconfirmed: "A message with a confirmation link has been sent to your email address. Please open the link to activate your account."
      signed_up_but_inactive: "You have signed up successfully. However, we could not sign you in because your account is not yet activated."
      signed_up_but_locked: "You have signed up successfully. However, we could not sign you in because your account is locked."
      updated: "You updated your account successfully."
      update_needs_confirmation: "You updated your account successfully, but we need to verify your new email address. Please check your email and click on the confirm link to finalize confirming your new email address."
      destroyed: "Bye! Your account was successfully cancelled. We hope to see you again soon."
    unlocks:
      send_instructions: "You will receive an email with instructions about how to unlock your account in a few minutes."
      unlocked: "Your account has been unlocked successfully. Please sign in to continue."
      send_paranoid_instructions: "If your account exists, you will receive an email with instructions about how to unlock it in a few minutes."
    omniauth:
      success: "Successfully authorized via %{kind} account."
      failure: "%{kind} authorization failed for the following reason: %{reason}."
    mailer:
      confirmation_instructions:
        subject: "Confirmation instructions"
      reset_password_instructions:
        subject: "Reset password instructions"
      unlock_instructions:
        subject: "Unlock Instructions"
  
  # Reader
  app: "The Old Reader"
  eggs: "We ♥ kittens"
  title: "The Old Reader"
  meta:
    description: "It's the ultimate RSS reader. Just like the old google reader, only better. Import your subscriptions in one click, find your Facebook friends and start sharing."
    keywords: "the old reader"
  landing:
    topmenu:
      -
        :title: "Twitter"
        :url: "https://twitter.com/#!/theoldreader"
      -
        :title: "Facebook"
        :url: "https://www.facebook.com/theoldreader"
      - 
        :title: "Blog"
        :url: "http://blog.theoldreader.com/"
      - 
        :title: "Contact us"
        :url: "http://blog.theoldreader.com/about"
    sign_in:
      title: "Sign in using:"
      google: "Google"
      facebook: "Facebook"
    welcome: 
      - "Welcome to The Old Reader, the ultimate social RSS reader. It's just like the old google reader, only better. We're in beta right now, but we're constantly working on improvements and new features."
      - "You can sign in and start using The Old Reader with a single click. However, if you are too shy, please feel free to see our %tour% or peek at the %trending%."
    tour: "Howto"
    trending: "top posts of the day"
    qa:
      -
        :title: "What does it do?"
        :text: "It allows you to browse your daily dose of content with that very special bit shared by your friends, with notes and comments"
      -
        :title: "Can I transfer my subscriptions?"
        :text: "Yes, you can import your feeds directly from your Google Reader account or use our OPML import feature if you're sensitive about your security."
      -
        :title: "How do I find my friends?"
        :text: "We're working on improving the friend suggestion page, but in the mean time you can search for your buddies manually or see who among your Facebook friends or Google contacts is also using The Old Reader. We'll also send you an e-mail when someone starts following you."
      -
        :title: "Do you have a mobile app?"
        :text: "Not <em>yet</em>, but as we had promised earlier, we started working on it when our user count reached 5000 in October 2012. Even now our standard interface adapts nicely to mobile devices."
      -
        :title: "Will you misbehave on my Facebook like those other apps?"
        :text: "Absolutely not! You can post your shared items on your timeline, but unless you choose to post to Facebook, all your shares and comments will stay in The Old Reader only. We'll never post anything else on your behalf or involve you in any other shady scheme."
      -
        :title: "Why did you build The Old Reader?"
        :text: "Let's just say we missed the original reader a lot, so we built The Old Reader for ourselves and our friends. We like the way it turned out, so we are sharing it with everyone"
    supported: "Supported with love by"
  user:
    profile: "Profile"
    logout: "Logout"
    settings: "Settings"
    failure: "The %{kind} account you are trying to use has already been linked to some other The Old Reader account. Please cancel your other account and retry the operation."
    wrong_auth: "Something went wrong, please contact us at hello@theoldreader.com"
    becomes_active_notice: "You have not used The Old Reader for a while, so we kept only fresh posts for you"
  feeds:
    no_feeds:
      text: "You have no subscriptions yet. You can %{subscribe} to a new feed (how about <a href='http://blog.theoldreader.com/rss' class='feed-subscribe'>our blog</a>?) or %{import} your subscriptions.<br />If you want to learn more, %{tour}."
      subscribe: "subscribe"
      import: "import"
      tour: "see the Howto"
    no_posts: "There are no posts here yet"
    no_posts_filler: "No posts below this line. Probably you have read them all."
    subscribe: "Subscribe"
    add_subscription: "Add a subscription"
    add: "Add"
    url: "Feed URL"
    invalid_url: "You have provided invalid URL"
    empty_url: "You have not provided URL"
    loading: "Loading..."
    default_folder: "Subscriptions"
    feeds: "Feeds"
    feeds_count:
      one: "feed"
      few: "feeds"
      many: "feeds"
      other: "feeds"
    posts_count:
      one: "post"
      few: "posts"
      many: "posts"
      other: "posts"
    your_posts: "You have <em>%{unread}</em> unread %{posts}"
    refresh: "Refresh"
    unsubscribe: "Unsubscribe"
    unsubscribe_confirm: "Do you really want to unsubscribe? Your shared and likes posts from this feed will not be removed."
    ago: "ago"
    never: "Never"
    confirm: "Are you sure?"
    mark_all_read: "Mark all as read"
    search: "Search"
    search_limits: "Search query that you used is very popular, so we had to limit the number of search results. If you wish to see all results, please make your search query more strict."
    mark_read: "Mark as read"
    mark_unread: "Mark as unread"
    share: "Share"
    shared: "Shared"
    unshare: "Unshare"
    following: "Following"
    attach_note: "Want to add a note?"
    attach: "Save note"
    comments:
      one: "%{count} comment"
      few: "%{count} comments"
      many: "%{count} comments"
      other: "%{count} comments"
    comment: "Comment"
    comment_text: "Write comment"
    comment_destroy_confirm: "Do you really want to delete the comment?"
    comment_destroy_text: "This comment has been deleted by the user."
    post_author: "by <strong>%{author}</strong>"
    drop_add_folder: "Drop here to add a new folder"
    new_folder: "New folder"
    like: "Like"
    unlike: "Unlike"
    likes_count:
      zero: "%{users} likes this"
      one: "%{users} and one other like this"
      few: "%{users} and %{count} others like this"
      many: "%{users} and %{count} others like this"
      other: "%{users} and %{count} others like this"
    feed: "Feed"
    site: "Site"
    enclosure_url: "View attached file (%{size}, %{type})"
    pocket: "Pocket"
    unpocket: "Unpocket"
    pocket_error: "Failed"
  home:
    following: "Latest from your friends"
    updated: "Recently updated"
    dead: "Dead feeds"
    tips:
      title: "Tips & tricks"
      items:
        - "Use \"j\" and \"k\" keyboard shortcuts to navigate posts. \"o\" opens the post in a new window."
        - "Some more keyboard shortcuts: use \"s\" to share a post or \"l\" to mark it as liked."
        - "Drag & drop feeds in the menu to reorder them or to create new feed folders."
        - "You can double click on feed or folder title to rename it."
        - "To subscribe to new feeds with a single click, use 'http://theoldreader.com/feeds/subscribe?url=%s' in RSS Subscription extension or Firefox feed handler."
  pages:
    home: "Home"
    all: "All items"
    liked: "Liked"
    shared: "Shared"
    followed: "Friends"
    import: "Import"
    search: "Search"
    settings: "Settings"
    profile: "Profile"
    friends: "Find Friends"
    commented: "Commented"
    privacy: "Privacy policy"
    trending: "Trending"
    donate: "Donate"
    tour: "Howto"
    blog: "Blog"
    status: "Server status"
    community: "Community resources"
  settings:
    name: "Name"
    username: "Username"
    email: "Email"
    ui:
      title: "User interface"
      click_to_scroll: "Clicking on a post scrolls to it"
      scroll_to_read: "Scrolling through posts marks them as read"
      sidebar_unread_only: "Show only those folders/feeds that have unread items"
      locale: "Language"
    feed_display_mode:
      title: "Feed display mode"
      all: "Show all posts"
      unread: "Show unread only"
    feed_list_mode:
      title: "Posts view mode"
      full: "Full view"
      list: "List view"
    sort_mode:
      title: "Posts order"
      normal: "Normal (new posts first)"
      reverse: "Reverse (old posts first)"
    social: "Social stuff"
    notify_when_followed: "Notify by email when someone starts following you"
    share_timeline: "Publish your shares on your Facebook page"
    connect_share_timeline: "Connect to Facebook to publish your shares"
    show_fb_profile: "Show link to your Facebook page in your profile"
    save: "Save changes"
    cancel_disabled: "You can't cancel your account while import is in progress, please be patient."
    cancel_account:
      text: "Unhappy? You can %{export} as OPML file and %{cancel} at any time."
      export: "export your feeds"
      cancel: "cancel your account"
      confirm: "Are you sure?"
    pocket:
      title: "Pocket integration"
      description: "<a href='http://getpocket.com/'>Pocket</a> (formerly called Read It Later) is a handy app that allows you to arrange, sort, and tag content that you intend to access later."
      connect: "Connect to Pocket to start pocketing"
      account: "Your account: <strong>%{username}</strong>"
  import:
    title: "Import"
    alert: "<b>Please enter your Google username and password to import your subscriptions from Google Reader</b><br />We are not going to store your credentials. Account information will only be used to fetch your subscriptions."
    opml: "<b>Choose an OPML file</b><br />You can grab it from Google Reader settings page.<br />Please use <b>subscriptions.xml</b> from your takeout archive."
    email: "Email"
    password: "Password"
    import: "Import"
    started: "We find feed import to be quite resource intensive procedure, so our system only allows a limited number of import operations to run at the same time. Currently all available slots are busy, so your import operation will be queued."
    queued: "Thank you for uploading your OPML file. We will soon start importing your subscriptions."
    queued_notice: "There are <strong>%{count}</strong> users in the import queue ahead of you."
    processing: "Your feeds are now importing in background."
    error: "Something went wrong"
    opml_empty: "OPML file you uploaded is either incorrect or empty."
    too_many_feeds: "For technical reasons we will only import first 1000 of your feeds."
    cancel: "Cancel import"
  profile:
    follow: "Follow"
    unfollow: "Unfollow"
    thats_you: "That's you!"
    following: 
      one: "Follows <strong>%{count}</strong> user"
      few: "Follows <strong>%{count}</strong> users"
      many: "Follows <strong>%{count}</strong> users"
      other: "Follows <strong>%{count}</strong> users"
    followers:
      one: "Followed by <strong>%{count}</strong> user"
      few: "Followed by <strong>%{count}</strong> users"
      many: "Followed by <strong>%{count}</strong> users"
      other: "Followed by <strong>%{count}</strong> users"
    me_following: "<strong>%{count}</strong> Following"
    my_followers: "<strong>%{count}</strong> Followers"
    posts: "Shared posts"
    your_profile: "Your profile"
    facebook: "Facebook (%{name})"
    new: "New"
    new_followers:
      one: "%{count} new"
      few: "%{count} new"
      many: "%{count} new"
      other: "%{count} new"
    rss: "%{name} shared items on The Old Reader (RSS)"
  friends:
    follow: "Follow your friends who use The Old Reader"
    found:
      one: "Found %{count} user"
      few: "Found %{count} users"
      many: "Found %{count} users"
      other: "Found %{count} users"
    facebook: "Login with Facebook"
    google: "Login with Google"
  notifier:
    followed:
      subject: "%{name} has followed you"
      body: |
        Hello, %{followed}!
        
        %{name} is now following you. Nice!
        See profile at %{profile}.
        
        -- 
        The Old Reader robot.
        You can always unsubscribe at your settings page.
        %{host}
    import:
      subject: "Your feeds are ready, hooray!"
      body: |
        Hello %{name},
        
        We are happy to inform you that we have finished importing your subscriptions.
        %{count} feeds you imported should now be available at %{host}.
        Thank you for using The Old Reader.
        
        -- 
        The Old Reader robot.
        %{host}
    changes:
      subject: "Important note regarding Starred items"
