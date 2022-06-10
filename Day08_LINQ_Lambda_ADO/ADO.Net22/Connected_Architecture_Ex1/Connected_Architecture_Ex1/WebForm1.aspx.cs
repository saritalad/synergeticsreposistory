using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Connected_Architecture_Ex1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static SqlConnection con;
        public static SqlCommand com;
        public static SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myconnect"].ToString());


                   }

        protected void Button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                string str = "insert into employee(firstname,lastname,salary,regno)values(@fname,@lname,@salary,@regno)";
                com = new SqlCommand(str, con);
                com.Connection = con;
              
            
                com.Parameters.AddWithValue("@fname", TextBox1.Text);
                com.Parameters.AddWithValue("@lname", TextBox2.Text);
                com.Parameters.AddWithValue("@salary", Convert.ToDecimal(TextBox3.Text));
                com.Parameters.AddWithValue("@regno", Convert.ToInt32(TextBox4.Text));
               
                con.Open();
                
                com.ExecuteNonQuery();
               
                Response.Write("<script>alert('record added successfully');</script>");
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
              
            }
              con.Close();


        }
    }
}