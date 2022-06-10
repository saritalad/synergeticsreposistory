using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace ADo_Net_example1
{  //asp.net :  active server page  
    // ADO .net   active data object  is a framework to do data opration CRUD  
    //CREATE , RETRRIEVE ,UPDATE  AND DELTE
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static SqlConnection con;
        public static SqlCommand com;
        public static SqlDataReader dr;
        public static DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myconnect"].ToString());
                com = new SqlCommand();// object of SqlCommand 
                com.Connection = con;// property of SqlCommand
                com.CommandText = "select regno,firstname,lastname,salary,city from employee";// property
                con.Open();
               dr=com.ExecuteReader();// method in SqlCommand
                dt = new DataTable();
                dt.Load(dr);

                GridView1.DataSource = dt;
                GridView1.DataBind();


            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);

            }
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            com.CommandText = "insert into employee (regno,firstname,lastname)values(@regno,@fname,@lname)";
            com.Parameters.AddWithValue("@regno", Convert.ToInt32(txtregno.Text));
            com.Parameters.AddWithValue("@fname",txtfirstname.Text);
            com.Parameters.AddWithValue("@lname", txtlastname.Text);
            con.Open();
            com.ExecuteNonQuery();
            Response.Write("<script>alert('record added successfully')</script>");
            con.Close();

        }

        
    }
}