using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class HiddenFieldDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                hfHitcount.Value = 0.ToString();

        }

        protected void btnHitCount_Click(object sender, EventArgs e)
        {
            int count=Convert.ToInt32(hfHitcount.Value) + 1;
            Response.Write("Count Value: " + count);
            hfHitcount.Value = count.ToString();

        }
    }
}