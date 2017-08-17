using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResponsiveWebsite2
{
    public partial class ProductView : System.Web.UI.Page
    {
        StockDAO stockDao = new StockDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string type = Request.QueryString["type"];
                rptrProducts.DataSource = stockDao.getAllChocolates(type).Tables[0];
                rptrProducts.DataBind();
            }
        }
    }
}