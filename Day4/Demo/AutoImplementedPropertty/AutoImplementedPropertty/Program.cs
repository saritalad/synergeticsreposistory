using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoImplementedPropertty
{
    class Program
    {
        class time
        {
            public int Hour { get; set; }
            public int minute { get; set; }
            public int Second { get; set; }
            
public void display()
{Console .WriteLine ("Hello ! Time is :"+Hour +":"+minute +":"+ Second );
}        }
        static void Main(string[] args)
        {
            time t1=new time ();
           
            t1.Hour = 1;
            t1.minute = 10;
            t1.Second = 5;
            t1.display();
           /* no constructor defined */
        }
    }
}
