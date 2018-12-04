using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class Family_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserData"] == null)
                Response.Redirect("PersonalDetails.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> Details = (Dictionary<string,object>)Session["UserData"];
            Details.Add("Spouse", TextBox1.Text);
            Details.Add("FatherName", TextBox2.Text);
            Details.Add("MotherName", TextBox3.Text);
            Details.Add("Children", TextBox4.Text);
            Session["UserData"] = Details;
            Response.Redirect("Details.aspx");
        }
    }
}