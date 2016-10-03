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
using WMPLib;
using DatabaseHelper;
using System.Reflection;


namespace MediaPlayerMidterm
{
    public partial class _Default : Page
    {

        string mPath = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            Post post = new Post();
            //rptMusic.DataSource = postList.List;
            //rptMusic.DataBind();

            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = @"C:\Users\Matt\Documents\MediaPlayerMidterm\MediaPlayerMidterm\MediaPlayerMidterm\" + mPath;
        }

        

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            
            Post post = new Post();

            if (txtArtist.Text != null && txtTrack.Text != null && this.fuUpload.HasFile)
            {
                string path = Server.MapPath("./UploadedMusic");
                path = Path.Combine(path, this.fuUpload.FileName);
                string relativePath = Path.Combine("UploadedMusic", this.fuUpload.FileName);
                this.fuUpload.SaveAs(path);

                post.ArtistName = txtArtist.Text.ToString();
                post.TrackName = txtTrack.Text.ToString();
                post.MusicPath = relativePath;
                post.Save();
                Response.Redirect("~/Default.aspx");
            }         
        }


        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb1 = new ListBox();
            lb1.SelectedItem.Value = mPath.ToString();
        }
    }
}