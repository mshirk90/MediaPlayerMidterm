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


namespace MediaPlayerMidterm
{
    public partial class _Default : Page
    {

        

        protected void Page_Load(object sender, EventArgs e)
        {
            PostList postList = new PostList();
            postList = postList.GetAll();
            rptMusic.DataSource = postList.List;
            rptMusic.DataBind();

            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = "/UploadedMusic";
            myplayer.controls.play();
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

        public void rptMusic_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            Label label = (Label)this.FindControl("lblMusicPath");
            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            myplayer.URL = "lblMusicPath";
            myplayer.controls.play();
        }
    }
}