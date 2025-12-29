using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElectricBill
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            if (username == "" || password == "")
            {
                lblMsg.Text = "Username and Password cannot be empty";
                lblMsg.ForeColor = System.Drawing.Color.Red;
                return;
            }
            if (username.Equals("Mani") && password.Equals("Sai"))
            {
                Session["Admin"] = username;
                Response.Redirect("~/Default.aspx");
            }
            else
            {                lblMsg.Text = "Invalid Username or Password";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}