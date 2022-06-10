using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO_SP_StoredProcedure_Example
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public static SqlConnection con;
        public static SqlCommand com;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt1,dt2;

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myconnect"].ToString()))
                {

                    com = new SqlCommand()
                    {
                        CommandText = "SP_AddProduct",
                        Connection = con,
                        CommandType = CommandType.StoredProcedure

                    };
                    SqlParameter param1 = new SqlParameter()
                    {
                        ParameterName = "@name",
                        SqlDbType = SqlDbType.VarChar,
                        Value = TextBox1.Text,
                        Direction = ParameterDirection.Input
                    };

                    SqlParameter param2 = new SqlParameter()
                    {
                        ParameterName = "@price",
                        SqlDbType = SqlDbType.Decimal,
                        Value = TextBox2.Text,
                        Direction = ParameterDirection.Input
                    };
                    SqlParameter param3 = new SqlParameter()
                    {
                        ParameterName = "@catid",
                        SqlDbType = SqlDbType.Int,
                        Value = DropDownList1.SelectedItem.Value,
                        Direction = ParameterDirection.Input
                    };
                    com.Parameters.Add(param1);
                    com.Parameters.Add(param2);
                    com.Parameters.Add(param3);
                    con.Open();
                    com.ExecuteNonQuery();
                    Response.Write("<script>alert('Record Added Successfully');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('error');</script>");
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ds.Tables[1];

            GridView1.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myconnect"].ToString()))
                {

                    com = new SqlCommand()
                    {
                        CommandText = "SP_updateProduct",
                        Connection = con,
                        CommandType = CommandType.StoredProcedure

                    };
                    SqlParameter param1 = new SqlParameter()
                    {
                        ParameterName = "@name",
                        SqlDbType = SqlDbType.VarChar,
                        Value = TextBox1.Text,
                        Direction = ParameterDirection.Input
                    };

                    SqlParameter param2 = new SqlParameter()
                    {
                        ParameterName = "@price",
                        SqlDbType = SqlDbType.Decimal,
                        Value = TextBox2.Text,
                        Direction = ParameterDirection.Input
                    };
                    SqlParameter param3 = new SqlParameter()
                    {
                        ParameterName = "@catid",
                        SqlDbType = SqlDbType.Int,
                        Value = DropDownList1.SelectedItem.Value,
                        Direction = ParameterDirection.Input
                    };
                    SqlParameter param4 = new SqlParameter()
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = DropDownList1.SelectedItem.Value,
                        Direction = ParameterDirection.Input
                    };

                    com.Parameters.Add(param1);
                    com.Parameters.Add(param2);
                    com.Parameters.Add(param3);
                    com.Parameters.Add(param4);
                    con.Open();
                    com.ExecuteNonQuery();
                    Response.Write("<script>alert('Record Added Successfully');</script>");

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('error');</script>");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myconnect"].ToString()))
                {

                    com = new SqlCommand()
                    {
                        CommandText = "SP_searchProduct",
                        Connection = con,
                        CommandType = CommandType.StoredProcedure

                    };
                    SqlParameter param1 = new SqlParameter()
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = Convert.ToInt32(TextBox3.Text),
                      //  Direction = ParameterDirection.Input
                    };
                    com.Parameters.Add(param1);
                    con.Open();
                 SqlDataReader dr=com.ExecuteReader();
                    if(dr.HasRows)
                        Response.Write("<script>alert('found');</script>");
                    else
                        Response.Write("<script>alert('!Not found');</script>");
                }
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }

        }

        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myconnect"].ToString());
                da = new SqlDataAdapter("select Catid,catname from category;select id,name,price,categoryId from product", con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                da.Fill(ds);
                dt1 = ds.Tables[0];
                DropDownList1.DataSource = dt1;
                DropDownList1.DataTextField = "Catname";
                DropDownList1.DataValueField = "CatId";
                da.Fill(ds);

            }
          
            GridView1.DataSource = ds.Tables[1];
            Page.DataBind();

        }
    }
}