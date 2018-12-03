using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class LoginFormWithStaySignedIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["HitCount"] = 0;
                txtUser.Focus();
            }
            ;
            if (Request.Cookies["LoginCookie"] != null)
                Response.Redirect("SuccessStaySignedIn.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int count;
            if (txtUser.Text == "admin" && txtPwd.Text == "admin")
            {
                HttpCookie cookie = new HttpCookie("LoginCookie");
                cookie["user"] = txtUser.Text;
                cookie["pwd"] = txtPwd.Text;
                if(cbMsg.Checked)
                cookie.Expires = DateTime.Now.AddMonths(1);
                Response.Cookies.Add(cookie);
                Response.Redirect("SuccessStaySignedIn.aspx");
            }
            else
            {
                count = (int)ViewState["HitCount"] + 1;
                lblMsg.Text = "Failure " + count + " attempt(s), maximum are 3";
                if (count == 3)
                {
                    Response.Cookies["user"].Value = txtUser.Text;
                    Response.Redirect("FailureStaySignedIn.aspx");
                }
                ViewState["HitCount"] = count;
            }
        }
    }
}