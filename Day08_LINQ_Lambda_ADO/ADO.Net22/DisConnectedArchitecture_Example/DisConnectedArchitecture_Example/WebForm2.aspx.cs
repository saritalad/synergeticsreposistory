using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DisConnectedArchitecture_Example
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public static SqlConnection con;
        public static SqlCommand com;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt, dt1;

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables[0]);
                Response.Write("<script>alter('record updated successfully')</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alter('error'+ex.Message)</script>");
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myconnect"].ToString());
            da = new SqlDataAdapter("select * from employee", con);
            ds = new DataSet();
            da.Fill(ds);
           
            DataView dv = ds.Tables[0].DefaultView;
            dv.Sort = "FirstName";
          //  dv.RowFilter = "regno<12";
            // Add DataView Event Handlers  
            DataRowView rw = dv.AddNew();
            rw.BeginEdit();
            rw["Firstname"] = "xxx";
            rw["Lastname"] = "yyy";
            rw.EndEdit();
         // DataView dv1=  new DataView(ds.Tables[0],"","Firstname",DataViewRowState.CurrentRows);

          

            GridView1.DataSource = dv;

            Page.DataBind();
        }
    }
}