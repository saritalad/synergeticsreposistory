using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace DisConnectedArchitecture_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static SqlConnection con;
        public static SqlCommand com;
        public static SqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt,dt1;

        protected void Page_Load(object sender, EventArgs E)
        {      if (!Page.IsPostBack)
            {
                con = new SqlConnection(WebConfigurationManager.ConnectionStrings["myconnect"].ToString());
                da = new SqlDataAdapter("select * from employee;select * from departments", con);
                da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                ds = new DataSet();
                da.Fill(ds);
                dt = ds.Tables[0];
                dt1 = ds.Tables[1];

                DropDownList1.DataSource = dt1;
                DropDownList1.DataTextField = "deptname";
                DropDownList1.DataValueField = "deptid";
                
            }
          //  GridView1.DataSource = ds.Tables[0];
          // linq to dataset example
            var query =  from d in dt1.AsEnumerable()
                         join e in dt.AsEnumerable()
                         on d.Field<int>("deptId") equals
                         e.Field<int>("Dept_Id")
                        select new
                        {
                            EmployeeId = e.Field<int>("Id"),
                            Name = e.Field<string>("FirstName"),
                            DepartmentId = d.Field<int>("DeptId"),
                            DepartmentName = d.Field<string>("deptName")
                        };
            GridView1.DataSource = query;


            Page.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          
            int id = Convert.ToInt32(txtid.Text);
        //    string str = "update employee set firstname=@fname,lastname=@lname,salary=@sal,regno=@regno,dept_id=@deptid where id =@id";
         //   com = new SqlCommand(str, con);
            DataRow modifiedrow = dt.Rows.Find(id);
            modifiedrow["firstname"] = TextBox1.Text;
            modifiedrow["lastname"] = TextBox2.Text;
            modifiedrow["salary"] = Convert.ToDecimal(TextBox3.Text);
            modifiedrow["regno"] = Convert.ToInt32(TextBox4.Text);
            modifiedrow["city"] = TextBox5.Text;
            modifiedrow["dept_id"] = DropDownList1.SelectedItem.Value;
            new SqlCommandBuilder(da);
            da.Update(ds);
            Response.Write("<script>alert('Record Updated Successfully')</script>");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            DataRow row = dt.Rows.Find(id);
            if (row != null)
               dt.Rows.Remove(row);
            new SqlCommandBuilder(da);
            da.Update(ds);
        }

        

        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = ds.Tables[0];
            
            Page.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string str = "insert into employee(firstname,lastname,salary,regno)values(@fname,@lname,@salary,@regno)";
                //com = new SqlCommand(str, con);
                DataRow newRow = dt.NewRow();
                 newRow["firstname"] = TextBox1.Text;
                newRow["lastname"] = TextBox2.Text;
                newRow["salary"] = Convert.ToDecimal(TextBox3.Text);
                newRow["regno"] = Convert.ToInt32(TextBox4.Text);
                newRow["city"] = TextBox5.Text;
                newRow["dept_id"] = DropDownList1.SelectedItem.Value;
                 ds.Tables[0].Rows.Add(newRow);

                new SqlCommandBuilder(da);
                da.Update(ds);
                da.Dispose();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}