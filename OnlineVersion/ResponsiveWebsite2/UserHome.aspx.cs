using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResponsiveWebsite2
{
    public partial class UserHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                lblusername.Text = "Welcome    " + Session["username"].ToString();

            }
        }

        protected void signout_btn_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("Default.aspx");
        }
    }
}