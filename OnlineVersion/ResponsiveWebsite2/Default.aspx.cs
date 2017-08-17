using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResponsiveWebsite2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           BindCartNumber();
        }
        protected void signout_btn_Click(object sender, EventArgs e)
        {
            
            Session["username"] = null;
            Response.Redirect("SignIn.aspx");
        }

        public void BindCartNumber()
        {
            if (Request.Cookies["Cart_item_id"] != null)
            {
                string CookiePID = Request.Cookies["Cart_item_id"].Value.Split('=')[1];
                string[] ProductArray = CookiePID.Split(',');
                int ProductCount = ProductArray.Length;
                pCount.InnerText = ProductCount.ToString();
            }
            else
            {
                pCount.InnerText = 0.ToString();
            }
        }
    }
}