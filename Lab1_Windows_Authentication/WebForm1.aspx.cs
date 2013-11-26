using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1_Windows_Authentication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAuth.Text = "Is Authenticated = " + User.Identity.IsAuthenticated.ToString();
            lblType.Text = "Auth Type = " + User.Identity.AuthenticationType;
            lblName.Text = "Name = " + User.Identity.Name;
        }
    }
}