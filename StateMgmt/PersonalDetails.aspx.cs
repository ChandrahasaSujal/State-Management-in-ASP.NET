using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class PersonalDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Details = new Dictionary<string, object>();
            Details.Add("FirstName", TextBox1.Text);
            Details.Add("LastName", TextBox2.Text);
            Details.Add("EmailId", TextBox3.Text);
            Details.Add("PhoneNo", TextBox4.Text);
            Session["UserData"] = Details;
            Response.Redirect("FamilyDetails.aspx");
        }
    }
}