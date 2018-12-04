using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserData"] == null)
                Response.Redirect("PersonalDetails.aspx");
            Dictionary<string, object> Details = (Dictionary<string,object>)Session["UserData"];
            foreach(string key in Details.Keys)
            {
                Response.Write(key+": "+Details[key]+"<br />");
            }
        }
    }
}