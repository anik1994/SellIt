using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using ResponsiveWebsite2.DAO;
using ResponsiveWebsite2.DTO;

namespace ResponsiveWebsite2
{
    public partial class Cart : System.Web.UI.Page
    {
        StockDAO stockDao = new StockDAO();
        Vat_informerDAO vat_informerDao = new Vat_informerDAO();
        Customer_infoDAO customer_infoDao = new Customer_infoDAO();
        Order_tblDAO order_tblDao = new Order_tblDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindCartProducts();
            }
        }


        protected void btnBuyNow_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["Cart_item_id"] != null)
            {
                string item_name_append="", item_quantity_append="";
                string CookieData = Request.Cookies["Cart_item_id"].Value.Split('=')[1];
                string[] CookieDataArray = CookieData.Split(',');
                if (CookieDataArray.Length > 0)
                {
                    int item_idd, qtt=0,updateqt;
                    double total_vat=0;
                    int total_price=0;

                    for (int i = 0; i < CookieDataArray.Length; i++)
                    {
                        string item_idstr = CookieDataArray[i].ToString().Split('-')[0];
                        string qtstr = CookieDataArray[i].ToString().Split('-')[1];

                        //item_idd = Convert.ToInt32(item_idstr);
                        string barcode = item_idstr;
                        qtt = Convert.ToInt32(qtstr);

                        updateqt = (Convert.ToInt32(stockDao.getSingleItem(new StockDTO(barcode)).Tables[0].Rows[0]["rest_item"].ToString()))-qtt;
                        
                        stockDao.UpdateStock(new StockDTO(barcode,updateqt));

                        ////
                        String item_name = stockDao.getSingleItem(new StockDTO(barcode)).Tables[0].Rows[0]["item_name"].ToString();
                        item_name_append = item_name + "," + item_name_append ;
                        item_quantity_append = qtstr +  ","  + item_quantity_append;

                        String type = stockDao.getSingleItem(new StockDTO(barcode)).Tables[0].Rows[0]["type"].ToString();

                        int vat = (Convert.ToInt32(vat_informerDao.getVat(new Vat_informerDTO(type)).Tables[0].Rows[0]["vat"].ToString()));

                        
                        int sellprice_quan = qtt*  (Convert.ToInt32(stockDao.getSingleItem(new StockDTO(barcode)).Tables[0].Rows[0]["selling_price"].ToString()));
                        total_vat = total_vat + ((vat * sellprice_quan) / 100.0);
                        total_price = total_price + sellprice_quan;

                    }
                    string user = (string)(Session["username"]);
                    string cus_name = customer_infoDao.getSingleItem(new Customer_infoDTO(user)).Tables[0].Rows[0]["name"].ToString();
                    string address = customer_infoDao.getSingleItem(new Customer_infoDTO(user)).Tables[0].Rows[0]["address"].ToString();
                    string phn_no = customer_infoDao.getSingleItem(new Customer_infoDTO(user)).Tables[0].Rows[0]["phone_no"].ToString();

                    string total_cost_all = (total_price + total_vat).ToString();

                    order_tblDao.CreateOrder(new Order_tblDTO(cus_name,address,phn_no,item_name_append,item_quantity_append,total_price.ToString(),total_vat.ToString(),total_cost_all));

                    spanCartTotal.InnerText = total_price.ToString();
                    vat1.InnerText = total_vat.ToString();
                    spanTotal.InnerText = "Tk. " + total_cost_all.ToString();

                    ///////////////
                    HttpCookie CartProducts = Request.Cookies["Cart_item_id"];
                    CartProducts.Values["Cart_item_id"] = null;
                    CartProducts.Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies.Add(CartProducts);

                    Response.Redirect("Default.aspx");
                }
            }
        }

        protected void btnRemoveItem_Click(object sender, EventArgs e)
        {
            string CookiePID = Request.Cookies["Cart_item_id"].Value.Split('=')[1];
            Button btn = (Button)(sender);
            string PIDSIZE = btn.CommandArgument;

            // List<String> CookiePIDList = CookiePID.Split(',').Select(i => i.Trim()).Where(i => i != string.Empty).ToList();
            List<String> CookiePIDList = CookiePID.Split(',').ToList();
            CookiePIDList.Remove(PIDSIZE);
            string CookiePIDUpdated = String.Join(",", CookiePIDList.ToArray());

            if (CookiePIDUpdated == "")
            {
                HttpCookie CartProducts = Request.Cookies["Cart_item_id"];
                CartProducts.Values["Cart_item_id"] = null;
                CartProducts.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(CartProducts);

            }
            else
            {
                HttpCookie CartProducts = Request.Cookies["Cart_item_id"];
                CartProducts.Values["Cart_item_id"] = CookiePIDUpdated;
                CartProducts.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(CartProducts);

            }
            Response.Redirect("~/Cart.aspx"); //~/   = the user's home directory or the application's, in ASP
        }


        private void BindCartProducts()
        {
            if (Request.Cookies["Cart_item_id"] != null)
            {
                string CookieData = Request.Cookies["Cart_item_id"].Value.Split('=')[1];
                string[] CookieDataArray = CookieData.Split(',');
                if (CookieDataArray.Length > 0)
                {

                    DataTable dTable = new DataTable("Dynamically_Generated");

                    //DataColumn item_id = new DataColumn("item_id", typeof(string));
                    //dTable.Columns.Add(item_id);

                    DataColumn barcode = new DataColumn("barcode", typeof(string));
                    dTable.Columns.Add(barcode);

                    DataColumn item_name = new DataColumn("item_name", typeof(string));
                    dTable.Columns.Add(item_name);

                    DataColumn selling_price = new DataColumn("selling_price", typeof(string));
                    dTable.Columns.Add(selling_price);

                    DataColumn quantity = new DataColumn("quantity", typeof(string));
                    dTable.Columns.Add(quantity);
                    DataRow row = null;

                    int item_idd, qtt;
                    Int64 CartTotal = 0;
                    double total_vat = 0;
                    int total_price = 0;
                    for (int i = 0; i < CookieDataArray.Length; i++)
                    {
                        string item_idstr = CookieDataArray[i].ToString().Split('-')[0];
                        string qtstr = CookieDataArray[i].ToString().Split('-')[1];

                        string barcodee = item_idstr;
                        //item_idd = Convert.ToInt32(item_idstr);
                        qtt = Convert.ToInt32(qtstr);

                        rptrCartProducts.DataSource = stockDao.getSingleItem(new StockDTO(barcodee)).Tables[0];

                        row = dTable.NewRow();

                        row["barcode"] = stockDao.getSingleItem(new StockDTO(barcodee)).Tables[0].Rows[0]["barcode"].ToString();
                        row["item_name"] = stockDao.getSingleItem(new StockDTO(barcodee)).Tables[0].Rows[0]["item_name"].ToString();
                        row["selling_price"] = stockDao.getSingleItem(new StockDTO(barcodee)).Tables[0].Rows[0]["selling_price"].ToString();
                        row["quantity"] = qtstr;

                        dTable.Rows.Add(row);

                        CartTotal += (Convert.ToInt64(stockDao.getSingleItem(new StockDTO(barcodee)).Tables[0].Rows[0]["selling_price"].ToString())) * qtt;


                        String type = stockDao.getSingleItem(new StockDTO(barcodee)).Tables[0].Rows[0]["type"].ToString();

                        int vat = (Convert.ToInt32(vat_informerDao.getVat(new Vat_informerDTO(type)).Tables[0].Rows[0]["vat"].ToString()));


                        int sellprice_quan = qtt * (Convert.ToInt32(stockDao.getSingleItem(new StockDTO(barcodee)).Tables[0].Rows[0]["selling_price"].ToString()));
                        total_vat = total_vat + ((vat * sellprice_quan) / 100.0);
                        total_price = total_price + sellprice_quan;
                    }

                    rptrCartProducts.DataSource = dTable;
                    rptrCartProducts.DataBind();
                    divPriceDetails.Visible = true;

                    //double vat = (15 * CartTotal) / 100.00;
                    //double total = vat + CartTotal;
                    //spanCartTotal.InnerText = CartTotal.ToString();
                    //vat1.InnerText = vat.ToString();
                    //spanTotal.InnerText = "Tk. " + total.ToString();
                    spanCartTotal.InnerText = total_price.ToString();
                    vat1.InnerText = total_vat.ToString();
                    string total_cost_all = (total_price + total_vat).ToString();
                    spanTotal.InnerText = "Tk. " + total_cost_all.ToString();
                }
                else
                {
                    divPriceDetails.Visible = false;
                    h5NoItems.InnerText = "Your Cart Is Empty";
                }
            }
            else
            {
                divPriceDetails.Visible = false;
                h5NoItems.InnerText = "Your Cart Is Empty";
            }
        }
    }
}