﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Transaction_Example
{
    class Program
    {
        public static string ConnectionString = "data source=ABCComputer; initial catalog=HCLDB; integrated security=True";
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Before Transaction");
                GetAccountsData();
                MoneyTransfer();
                Console.WriteLine("After Transaction");
                GetAccountsData();
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong" + e.Message);
            }
            Console.ReadKey();

        }
        private static void GetAccountsData()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from Accounts", connection);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["AccountNumber"] + ",  " + sdr["CustomerName"] + ",  " + sdr["Balance"]);
                }
            }
        }
        private static void MoneyTransfer()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                // The connection needs to be open before we begin a transaction
                connection.Open();
                // Create the transaction object by calling the BeginTransaction method on connection object
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Associate the first update command with the transaction
                    SqlCommand cmd = new SqlCommand("UPDATE Accounts SET Balance = Balance - 500 WHERE AccountNumber = 'Account1'",
                        connection, transaction);
                    cmd.ExecuteNonQuery();
                    // Associate the second update command with the transaction
                    cmd = new SqlCommand("UPDATE MyAccounts SET Balance = Balance + 100 WHERE AccountNumber = 'Account2'",
                        connection, transaction);
                    cmd.ExecuteNonQuery();
                    // If everythinhg goes well then commit the transaction
                    transaction.Commit();
                    Console.WriteLine("Transaction Committed");
                }
                catch
                {
                    // If anything goes wrong, rollback the transaction
                    transaction.Rollback();
                    Console.WriteLine("Transaction Rollback");
                }
                connection.Close();
            }
        }
    }
}
