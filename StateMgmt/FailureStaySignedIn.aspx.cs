using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class FailureStaySignedIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["user"] == null)
                Response.Redirect("LoginFormWithStaySignedIn.aspx");
                string Name = Request.Cookies["user"].Value;
                Response.Write("Hello, " + Name + " you are credentials are wrong.");
        }
    }
}