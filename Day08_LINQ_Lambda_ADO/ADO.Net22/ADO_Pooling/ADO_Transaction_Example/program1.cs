//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//namespace ADO_Transaction_Example
//{
//    class program1
//    {
//      public static SqlConnection con;
//        public static SqlTransaction transaction;
//       public static  SqlCommand com;
//        public static string ConnectionString = "data source=ABCComputer; initial catalog=HCLDB; integrated security=True";
//        static void Main(string[] args)
//        {
//           con = new SqlConnection(ConnectionString);
//            try
//            {
//                using (SqlConnection con = new SqlConnection(ConnectionString))
//                {
//                    con.Open();
//                    transaction = con.BeginTransaction();
//                    com = new SqlCommand("update employee set salary=salary+10000 where id=1", con, transaction);
//                    com.ExecuteNonQuery();
//                    com = new SqlCommand("update employee set salary=salary+5000 where id=2", con, transaction);
//                    com.ExecuteNonQuery();
//                    transaction.Commit();
//                    Console.WriteLine("Transaction Committed");
                   
//                }
//            }
//            catch(Exception ex)
//            {
//                    transaction.Rollback();
//                Console.WriteLine(ex.StackTrace+" Rollback");
//            }
//            con.Close();
//        }



//    }
//}
