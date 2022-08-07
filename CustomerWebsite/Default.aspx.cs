using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerWebsite
{
    public partial class _Default : Page
    {
        private customerwebservice.PTSCustomerWebService service;
        protected void Page_Load(object sender, EventArgs e)
        {
            service = new customerwebservice.PTSCustomerWebService();
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            
            int id = service.Authenticate(usernameTextBox.Text, passwordTextBox.Text);
            
            if (id>0)
            {
                Session["id"] = id;
                Response.Redirect("ProjectDetails.aspx");
            }
            else
            {
                labelmessage.Text = "Incorrect Login Details, Please Try Again";
            }
        }
    }
}