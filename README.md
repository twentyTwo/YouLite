# YouLite
An attempt at a lightweight youtube browser. For now has simple GUI, systematics and a stupidly weird installation. Sorry about that.

##What is YouLite?
YouLite is an attempt at making a lightweight YouTube browser, that I could use whilst playing games to prevent my Google Chrome from eating up all the resources and taking up too much RAM.

##What do you hope to add?
I hope to add a YouTube browser so you can get videos directly from their API, removing the need to use chrome itself to get the video URLS. I also want to remove the PHP helper and implement the code directly into C#. I tried to do this but there's a problem when running queries through WebClients, whereas the PHP helper uses cURL.

##Installation

Step 1. Setup your preferred stack (XAMPP, WAMP, LAMP) and run Apache.

Step 2. Move the 'youtube' folder to your documentroot *It must stay in the folder, dont rename the folder either!*

Step 3. Run the exe in the debug, or install it to your system and with any luck it should work.

If it doesn't work make sure you have all needed dependancies! You need to install PHP cURL for this to work.
