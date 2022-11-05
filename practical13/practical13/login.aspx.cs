using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practical13
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            if (unameTextBox.Text == "Tejas" && passTextBox.Text == "123")
            {
                Session["uname"] = unameTextBox.Text;
                Response.Redirect("home.aspx");
            }
            else
            {
                messageLabel.Text = "Invalid username or password ";
            }
        }
    }
}