using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class LoginFormWithFailureCount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtUser.Focus();
                ViewState["FailureCount"] = 0;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text=="Admin" && txtPwd.Text=="Admin")
            {
                Response.Redirect("Success.aspx?Name=Admin");
            }
            else
            {
                int count = (int)ViewState["FailureCount"] + 1;
                if (count == 3)
                    Response.Redirect("Failure.aspx?Name="+txtUser.Text);
                lblMsg.Text = count + "attempt(s), maximum are 3";
                ViewState["FailureCount"] = count;
            }
        }
    }
}