using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
namespace ADO_SP_StoredProcedure_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static SqlConnection con;
        public static SqlCommand com;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt1,dt2;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myconnect"].ToString());
                da = new SqlDataAdapter("select Catid,catname from category;select id,name,price,categoryId from product", con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
             
                              da.Fill(ds);

            }
           
            GridView1.DataSource = ds.Tables[0];
            Page.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newrow = ds.Tables[0].NewRow();
                newrow["catname"] = TextBox1.Text;
                ds.Tables[0].Rows.Add(newrow);
                new SqlCommandBuilder(da);
                da.Update(ds);
                Response.Write("<script>alert('Record Added Successfully');</script>");
                ds.Dispose();
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('!Oh wrong ');</script>"+ex.Message);
            }



        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ds.Tables[0];
            Page.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            DataRow modifiedRow = ds.Tables[0].Rows.Find(id);
            modifiedRow["catname"] = TextBox1.Text;
          
            new SqlCommandBuilder(da);
            da.Update(ds);
            Response.Write("<script>alert('Record modified Successfully');</script>");
            ds.Dispose();

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            try
            {
                com = new SqlCommand();
                com.CommandText = "select * from category where catid=@id";
                com.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                com.Connection = con;
                da = new SqlDataAdapter();
                da.SelectCommand = com;
                ds = new DataSet();
                da.Fill(ds,"Cats");
               if( ds.Tables[0].Rows.Count>0)
                    Response.Write("<script>alert('found !');</script>");
               else
                    Response.Write("<script>alert('no found !');</script>");

            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            dt1 = ds.Tables[0];
            dt1.TableName = "Category";
            dt2 = ds.Tables[1];
            DataRelation catProducts = new DataRelation("catproducts", dt1.Columns[0], dt2.Columns[3], false);
            ds.Relations.Add(catProducts);
            GridView2.DataSource = ds;
            GridView2.DataMember = dt1.TableName;
            GridView3.DataSource = ds;
            GridView3.DataMember = "cats.catproducts";

            Page.DataBind();

        }
    }
}