using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_Windows_Authentication
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAuth1.Text = "Is Authenticated = " + User.Identity.IsAuthenticated.ToString();
            lblType1.Text = "Auth Type = " + User.Identity.AuthenticationType;
            lblName1.Text = "Name = " + User.Identity.Name;
            lblIsInRole.Text = "Is in role of Admin = " + User.IsInRole("Administrators");
        }
    }
}