using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ_Example
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int[] nums = new int[] { 0, 1, 2, 3, 4, 5, 6, 73 };
        int[] Numbers = { 20, 40, 60, 80, 100, 120 };
        int[] factorof300 = { 2, 3, 2, 5, 5, 6, 7, 8, 9 };

        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        string[] words = { "believe", "relief", "receipt", "field" };

        int[] numbers = { 1, 11, 3, 19, 4, 45, 41, 65, 19 };
        int[] numberA = { 0,100, 1, 2, 4, 5, 6, 8, 9 };
        int[] numberB = { 1, 3,12 ,5, 7, 8 };
        protected void Page_Load(object sender, EventArgs e)
        {

            var result1 = from n in numbers
                          where n < 50
                          select n;

            DropDownList1.DataSource = result1;
            DropDownList1.DataBind();

            var reversedigits = (from d in digits
                                where d[1] == 'i'
                                select d).Reverse();
            DropDownList2.DataSource = reversedigits;
           

            var result = from w in words
                         select w;
            DropDownList3.DataSource = result;
            //Any() works like OR operator 
            bool iAfterE = words.Any(w => w.Contains("ei"));
            Label2.Text = iAfterE.ToString();
            // All() works like AND operator
            bool eAfterI = words.All(w => w.Contains("ie"));
            Label3.Text = eAfterI.ToString();
            bool onlyodd = numbers.All(n => n % 2 == 1);
           // var aOnlyNumbers = numberA.Except(numberB);
           // //var commonNumbers = numberA.Intersect(numberB);
           //var uniqnumbers = numberA.Union(numberB);
          //  DropDownList4.DataSource = aOnlyNumbers;

            Page.DataBind();
        }
    }
}




//Double avg = Numbers.Average();
//int sum = Numbers.Sum();
//int min = Numbers.Min();
//int max = Numbers.Max();
//int count = Numbers.Count();
//string[] words = { "believe", "relief", "receipt", "field" };
//bool onlyodd = numbers.All(n => n % 2 == 1);
//bool iAfterE = words.Any(w => w.Contains("ei"));//AND-> All  Any -> OR
//Label1.Text = iAfterE.ToString();
//        Label2.Text = onlyodd.ToString();
//        Label3.Text = avg.ToString();
//        Label4.Text = sum.ToString();
//        Label5.Text = max.ToString();
//        Label6.Text = min.ToString();
//        Label7.Text = count.ToString();
//        DropDownList9.DataSource = numbers;
//        DropDownList9.DataBind();
       
//        DropDownList8.DataSource = words;
//        DropDownList8.DataBind();
//        Response.Write(onlyodd.ToString());
//        int[] numberA = { 0, 1, 2, 4, 5, 6, 8, 9 };
//int[] numberB = { 1, 3, 5, 7, 8 };
//var aOnlyNumbers = numberA.Except(numberB);
//var commonNumbers = numberA.Intersect(numberB);
//var uniqnumbers = numberA.Union(numberB);

//var uniquefactor = factorof300.Distinct();

//var reversedigits = (from d in digits
//                     where d[1] == 'i'
//                     select d).Reverse();
//// from n in datasource
////  where condition 
//// select n; 
