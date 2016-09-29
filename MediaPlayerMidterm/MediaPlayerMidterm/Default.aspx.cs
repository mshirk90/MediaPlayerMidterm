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
    }
}