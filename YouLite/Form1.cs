using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxAXVLC;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace YouLite
{
    public partial class Form1 : Form
    {
        public List<string> songList = new List<string> { }; // Stores video URLs (the googleurl.co.uk/blahblah ones!)
        public string parsedTitle = string.Empty; // Temp storage for the song titles

        public Form1(){InitializeComponent();}
        private void playButton_Click(object sender, EventArgs e){playNow();}
        private void queue_Click(object sender, EventArgs e){addToQueue();}

        private void playVid_MediaPlayerEndReached(object sender, EventArgs e)
        {
            restartPlayer();
            getNextSong(); // gets next song
        }
        
        private void playlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.playlist.IndexFromPoint(e.Location); // gets the playlist ID which is clicked
            if (index != System.Windows.Forms.ListBox.NoMatches) // if the listitem clicked is actually an item
            {
                selectFromPlaylist(index); // select from playlist using the selected item ID
            }
        }

        public string[] getValues(string youtubeURL)
        {
            string URL = youtubeURL; // parses the URL from the parameters
            string getInfo = "http://localhost/youtube/getvideo.php?videoid=" + URL + "&type=Download"; // gets the song info from PHP script (currently working on making this client side)
            string Info = new WebClient().DownloadString(getInfo); // downloads the entire webpage (impracticle but gets the job done !)
            HtmlAgilityPack.HtmlDocument readDoc = new HtmlAgilityPack.HtmlDocument();
            readDoc.LoadHtml(Info); // uses the lovely HTMLAgilityPack to read the loaded HTML
            var title = readDoc.DocumentNode.Descendants("section").Select(n => n.InnerText); // gets the title from the HTML
            var vid = readDoc.DocumentNode.Descendants("aside").Select(n => n.GetAttributeValue("href", "NOTHING")); // gets the video from the HTML
            foreach (var title2 in title)
            {
                parsedTitle = title2; // temp stores video title in string
            }
            foreach (var vid2 in vid)
            {
                if (vid2.Contains("mp4")) // gets the MP4 video link
                {
                    return new string[] {parsedTitle,vid2}; // returns string array with both title and video URL
                }
            }
            MessageBox.Show("Something went wrong, feel free to tell me what you did and if I can replicate it i'll fix it!"); // if for some reason it cant parse their request
            return null;
        }
        public void playNow()
        {
            string[] getArray = getValues(textUrl.Text); // gets values
            playVid.playlist.add(getArray[1], null, null); // add video directly to VLC's playlist
            playVid.playlist.next(); // skips over currently playing
            playVid.playlist.play(); // plays video the user requested be played
            currentlyPlaying.Text = "Currently Playing: " + getArray[0]; // shows currently playing
        }
        public void addToQueue()
        {
            string[] getArray = getValues(textUrl.Text); // gets values
            songList.Add(getArray[1]); // adds video to list
            playlist.Items.Add(getArray[0]); // adds title to playlist
        }
        public void selectFromPlaylist(int id)
        {
            restartPlayer(); // reboots the VLC player incase any crashes or bugs
            playVid.playlist.add(songList[id]); // adds requested to vlc playlist
            playVid.playlist.play(); // plays playlist, no need to skip since we restart the player!
            currentlyPlaying.Text = "Currently Playing: " + playlist.Items[id]; // shows currently playing
            songList.RemoveAt(id); // removes video from songlist
            playlist.Items.RemoveAt(id); // removes title from playlist
        }
        public void restartPlayer()
        {
            playVid.playlist.stop(); // stops currently playing
            playVid.playlist.items.clear(); // clears the list incase somethings stayed in there (sneaky ninja videos!)
            playVid.Refresh(); // refreshes the overall VLC object.
            currentlyPlaying.Text = "Currently Playing: Nothing! :(";
        }
        public void getNextSong()
        {
            for (int i = 0; i < playlist.Items.Count; i++) // gets first video it can find in the playlist
            {
                if (songList[i] != null) // if it finds a video into which the value isnt nullified / removed
                {
                    selectFromPlaylist(i); // selects the video from the playlist using the loops value
                    break; // breaks the loop, preventing overlapping and skipping videos
                }
            }
        }

        private void playVid_MediaPlayerEncounteredError(object sender, EventArgs e)
        {
            restartPlayer();
            getNextSong(); // gets next song

        }
    }
}
