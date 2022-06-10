using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataView_Sort_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Specify the column to sort on.
            //
            DataTable table = GetTable();
            table.DefaultView.Sort = "Weight";

            //
            // Display all records in the view.
            //
            DataView view = table.DefaultView;
            Console.WriteLine("=== Sorted by weight ===");
            for (int i = 0; i < view.Count; i++)
            {
                Console.WriteLine("{0}, {1}", view[i][0], view[i][1]);
            }

            //
            // Now sort on the Name.
            //
            view.Sort = "Name";
            //
            // Display all records in the view.
            //
            Console.WriteLine("=== Sorted by name ===");
            for (int i = 0; i < view.Count; i++)
            {
                Console.WriteLine("{0}, {1}", view[i][0], view[i][1]);
            }

        }


        static DataTable GetTable()
        {
            //
            // Here we create a DataTable with 2 columns.
            //
            DataTable table = new DataTable();
            table.Columns.Add("Weight", typeof(int));
            table.Columns.Add("Name", typeof(string));

            //
            // Here we add unsorted data to the DataTable and return.
            //
            table.Rows.Add(57, "Spot");
            table.Rows.Add(130, "Rover");
            table.Rows.Add(92, "Fred");
            table.Rows.Add(25, "Alice");
            table.Rows.Add(7, "Hunter");
            return table;
        }
    }
}
