using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.IO;
using BusinessObjects;
using System.Media;


namespace MediaPlayerMidterm
{
    public partial class _Default : Page
    {



        protected void Page_Load(object sender, EventArgs e)
        {
          
           
           
        }



        protected void btnUpload_Click(object sender, EventArgs e)
        {
            
            Post post = new Post();

            if (this.fuUpload.HasFile)
            {
                string path = Server.MapPath("./UploadedMusic");
                path = Path.Combine(path, this.fuUpload.FileName);
                string relativePath = Path.Combine("UploadedMusic", this.fuUpload.FileName);
                this.fuUpload.SaveAs(path);

                
                post.MusicPath = relativePath;
                post.Save();
                Response.Redirect("~/Default.aspx");


            }
        }

        public void btnPlay_Click(object sender, EventArgs e)
        {
            var soundsRoot = "C:/Users/Matt/Documents/MediaPlayerMidterm/MediaPlayerMidterm/MediaPlayerMidterm/MediaPlayerMidterm/UploadedMusic/";
            var rand = new Random();
            var soundFiles = Directory.GetFiles(soundsRoot, "*.wav");
            var playSound = soundFiles[rand.Next(0, soundFiles.Length)];

           SoundPlayer player1 = new SoundPlayer(playSound);
            player1.Play();
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            var soundsRoot = "C:/Users/Matt/Documents/MediaPlayerMidterm/MediaPlayerMidterm/MediaPlayerMidterm/MediaPlayerMidterm/UploadedMusic/";
            var rand = new Random();
            var soundFiles = Directory.GetFiles(soundsRoot, "*.wav");
            var playSound = soundFiles[rand.Next(0, soundFiles.Length)];

            SoundPlayer player1 = new SoundPlayer(playSound);
            player1.Play();
        }
    }
}