using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatement // logical folder to sepately keep same named classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Sarita";
            //   int rollno = 2;
            //Console.WriteLine("Name : "+name+"Roll No :"+rollno);
            //float x = 7.09f;
            //double a = 12.678, b = 67.098;
            //decimal price = 35.50m, amount = 1035.45m;
            //Console.WriteLine("a={0:f0}  b={1:f1} price={2:c}",a,b,price);                     //int age;
            //Console.WriteLine("Enter your age ");
            //age = Convert.ToInt32(Console.ReadLine());
            //if(age>=18)
            //    Console.WriteLine("You are eligible for voting ");
            //else

            //    Console.WriteLine("You are  not eligible for voting ");

            //char rainbowcolor;
            //Console.WriteLine("Press Key for Rainbow color from  V IBGYOR");

            //rainbowcolor = Convert.ToChar(Console.ReadLine());// "v" not 'v' "v"=  v\0
            //switch (rainbowcolor)
            //{

            //    case 'v':
            //    case 'V':
            //        Console.WriteLine("Fav color is Voilet ");
            //        break;
            //    case 'i':
            //    case 'I':
            //        Console.WriteLine("Fav color is Indigo ");
            //        break;
            //    case 'B':
            //    case 'b':
            //        Console.WriteLine("Fav color is Blue ");
            //        break;

            //    case 'g':
            //    case 'G':
            //        Console.WriteLine("Fav color is Green ");
            //        break;

            //               default: Console.WriteLine("Invalid input Try again !");

            //        break;

            //}

            //  switch can use char, int and enum and string  , but not decimal,float and double

            // datatype [] nameofarray= new datatype[size];
            int[] marks = new int[5];

            float[] price = { 12.50f, 34.0f, 78.98f, 35.90f };//to initialize
            foreach (float p in price)
             Console.WriteLine("price" + p );
            
            Console.WriteLine( " length of array =" + price.Length);

            //ArrayList,List  can use foreach statement to display data 
            Console.WriteLine("enter marks for five subjects");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The marks ara as follows");
            for (int i = 0; i < marks.Length;i++)
            { Console.WriteLine("marks " + marks[i]); }
               // marks[i] += 5;                            // marks[i] = marks[i] + 5;
              
           
            //foreachloop
            // syntax of foreach
            //foreach(datatye var in arrayname)  :note data type match with array datatype
            //foreach(int m in marks)
            //    Console.WriteLine(m);
            float[] current = new float[3];
            Console.WriteLine("enter float values");
            for (int i = 0; i < current.Length; i++)
                current[i] = (float)Convert.ToDouble(Console.ReadLine());// typecast 
            Console.WriteLine("Outputter is as follws" );
            foreach (float c in current)
            {
              //  c = c + 5;  //c=current[i]
                Console.WriteLine(c);
            }
            //int i = 9;
            //if (i > 0)
            //{
            //    Console.WriteLine(i + "is positive");
            //    Console.WriteLine("i =" + i);
            //}
            //else
            //{
            //    Console.WriteLine(i + "is negative");
            //    Console.WriteLine("i =" + i);
            //}

            


            Console.ReadKey();
        }
    }
}
