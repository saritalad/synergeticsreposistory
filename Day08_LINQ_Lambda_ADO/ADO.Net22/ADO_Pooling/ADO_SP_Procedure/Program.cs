using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ADO_SP_Procedure
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand com;
        public static string ConnectionString = "data source=ABCComputer; initial catalog=HCLDB; integrated security=True";
        static void Main(string[] args)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                com = new SqlCommand()
                {
                    CommandText = "SP_EmpById",
                    CommandType = CommandType.StoredProcedure,
                    Connection = con
                                 };

                SqlParameter param1 = new SqlParameter()
                {
                    ParameterName = "@Id",
                    SqlDbType = SqlDbType.Int,
                    Value = 1,
                    Direction = ParameterDirection.Input

                };
                com.Parameters.Add(param1);
                con.Open();
               SqlDataReader dr = com.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine("Emp Id "+dr[0]+" Name :"+dr[1]);
                }


            }

        }
    }
}
