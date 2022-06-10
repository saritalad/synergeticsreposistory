using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_Example
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        ArrayList singers;
        protected void Page_Load(object sender, EventArgs e)
        {
            singers = new ArrayList();
            singers.Add("Kishor");
            singers.Add("Ameet");
            singers.Add("Mukesh");
            singers.Add("Nitin");
            singers.Add("Lata");
            singers.Add("Asha");
            ListBox1.DataSource = singers;
            Page.DataBind();
        }
    }
}