using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResponsiveWebsite2
{
    public partial class SignIn : System.Web.UI.Page
    {
        Customer_infoDAO customer_infodao = new Customer_infoDAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UNAME"] != null && Request.Cookies["PWD"] != null)
                {
                    username.Text = Request.Cookies["UNAME"].Value;
                    password.Attributes["value"] = Request.Cookies["PWD"].Value;
                    CheckBox1.Checked = true;
                }
            }
        }

        protected void login_btn_Click(object sender, EventArgs e)
        {
            int count = customer_infodao.GetLoginInfo(new Customer_infoDTO(username.Text, password.Text));

            if (count == 1)
            {
                if (CheckBox1.Checked)
                {
                    Response.Cookies["UNAME"].Value = username.Text;
                    Response.Cookies["PWD"].Value = password.Text;

                    Response.Cookies["UNAME"].Expires = DateTime.Now.AddDays(15);
                    Response.Cookies["PWD"].Expires = DateTime.Now.AddDays(15);
                }
                else
                {
                    Response.Cookies["UNAME"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["PWD"].Expires = DateTime.Now.AddDays(-1);
                }


                Session["username"] = username.Text;
                Response.Redirect("Default.aspx");
                //Response.Write("LogIn SuccessFul");
            }
            else
            {
                //Response.Write("Login Failed");
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Login Failed')", true);
                lblError.Text = "Invalid Username or Password";
            }
        }

    }
}