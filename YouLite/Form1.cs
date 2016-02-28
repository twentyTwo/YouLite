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
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string URL = textUrl.Text;
            string parsedTitle = "";
            string getInfo = "http://localhost/youtube/getvideo.php?videoid=" + URL + "&type=Download";
            WebClient WC = new WebClient();
            string Info = WC.DownloadString(getInfo);
            HtmlAgilityPack.HtmlDocument readDoc = new HtmlAgilityPack.HtmlDocument();
            readDoc.LoadHtml(Info);
            var title = readDoc.DocumentNode
                .Descendants("section")
                .Select(n => n.InnerText);
            var vid = readDoc.DocumentNode
                .Descendants("aside")
                .Select(n => n.GetAttributeValue("href","NOTHING"));
           foreach (var vid2 in vid)
           {
               if(vid2.Contains("mp4"))
               {
                   playVid.playlist.add(vid2, null, null);
                   playVid.playlist.next();
                   playVid.playlist.play();
               }
           }
           foreach (var title2 in title)
           {
               parsedTitle = title2;
               currentlyPlaying.Text = "Currently Playing: " + title2;
           }
            
        }
    }
}
