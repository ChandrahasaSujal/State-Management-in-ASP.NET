using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMgmt
{
    public partial class DisplayingCountWithHiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Previous Page count value:"+Request.Form["hfHitCount"]);
        }
    }
}