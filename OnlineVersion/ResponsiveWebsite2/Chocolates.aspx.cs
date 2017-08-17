using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResponsiveWebsite2
{
    public partial class Chocolates : System.Web.UI.Page
    {
        StockDAO stockDao = new StockDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string type = "Chocolate";
                //rptrChocolates.DataSource = stockDao.getAllChocolates(type).Tables[0];
                //rptrChocolates.DataBind();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
           Response.Redirect("~/ProductDetails.aspx?item_id=" + ((LinkButton)sender).Text);
        }


    }
}