using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResponsiveWebsite2
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        StockDAO stockDao = new StockDAO();
       // DBConnect dbconnect = new DBConnect();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string item_idstr = Request.QueryString["item_id"];
                //int item_id = Convert.ToInt32(item_idstr);
                
                string barcode = Request.QueryString["barcode"];

                rptrProductDetails.DataSource = stockDao.getSingleItem(new StockDTO(barcode)).Tables[0];
                rptrProductDetails.DataBind();
            }
        }


        protected void add_to_cart_btn_Cliked(object sender, EventArgs e)
        {

            //Int64 item_id = Convert.ToInt64(Request.QueryString["item_id"]);

            string barcode = Request.QueryString["barcode"];
            string qt = quantity.Text;

            if (Request.Cookies["Cart_item_id"] != null)
            {
                string CookiePID = Request.Cookies["Cart_item_id"].Value.Split('=')[1];
                CookiePID = CookiePID + "," + barcode + "-" + qt;

                HttpCookie CartProducts = new HttpCookie("Cart_item_id");
                CartProducts.Values["Cart_item_id"] = CookiePID;
                CartProducts.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(CartProducts);
            }
            else
            {
                HttpCookie CartProducts = new HttpCookie("Cart_item_id");
                CartProducts.Values["Cart_item_id"] = barcode.ToString() + "-" + qt;
                CartProducts.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(CartProducts);
             }
             Response.Redirect("~/ProductDetails.aspx?barcode=" + barcode);

        }
    }
}