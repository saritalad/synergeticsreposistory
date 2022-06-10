using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Pooling
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            string ConnectionString = "data source=ABCComputer; initial catalog=HCLDB; integrated security=True; Pooling=true;";
            stopwatch.Start();
            for (int i = 0; i < 500; i++)
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                connection.Close();
            }
            stopwatch.Stop();
            Console.WriteLine($"Pooling=true, Time : {stopwatch.ElapsedMilliseconds} ms");
            Console.ReadKey();
        }
    }
    }

