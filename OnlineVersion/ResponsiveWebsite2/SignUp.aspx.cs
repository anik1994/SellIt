using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;


namespace ResponsiveWebsite2
{
    public partial class SignUp : System.Web.UI.Page
    {
        Customer_infoDAO customer_infodao = new Customer_infoDAO();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void signup_btn_Click(object sender, EventArgs e)
        {
            if (name.Text != "" & password1.Text != "" && address.Text != "" && email.Text != "" && password2.Text != "" && phoneno.Text != "")
            {

                if (password1.Text == password2.Text)
                {
                    customer_infodao.CreateCustomer(new Customer_infoDTO(name.Text, email.Text, password1.Text, address.Text, phoneno.Text));
                    Response.Redirect("SignIn.aspx");
                }
                else
                {
                    lblMsg.ForeColor = Color.Red;
                    lblMsg.Text = "Passwords do not match";
                    // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Password Didn't Match')", true);
                }
            }

            else {
                lblMsg.ForeColor = Color.Red;
                lblMsg.Text = "All Fields Are Mandatory";
            }
        }
    }
}