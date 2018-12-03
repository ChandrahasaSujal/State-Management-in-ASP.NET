using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class SuccessStaySignedIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["LoginCookie"];
            if (cookie == null)
                Response.Redirect("LoginFormWithStaySignedIn.aspx");
            Response.Write("Hello " + cookie["user"] + ", Welcome to site.");
        }
    }
}