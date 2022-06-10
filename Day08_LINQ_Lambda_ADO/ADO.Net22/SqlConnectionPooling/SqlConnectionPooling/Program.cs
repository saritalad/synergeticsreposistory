using System;
using System.Data.SqlClient;
using System.Diagnostics;
namespace SqlConnectionPooling
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            string ConnectionString = "data source=ABcomputer; initial catalog=HCLDB; integrated security=True; Pooling=true;";
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
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
