using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class Constantex 
    {
        public int a = 10 ;                            // there value can be change  ,, because the in that not use the const 
        public const double pi = 3.14485;
        public const string Appname = "MyApp";             // use of const the value can not change over the program 
         


        public void PrintConst()
        {
            Console.WriteLine($"The value of Pi is : {pi}");
            Console.WriteLine($"Application Name is:{Appname}");

        }
    
    }


    internal class Const
    {

        static void Main()
        {
            Constantex cons = new Constantex();
            cons.PrintConst();
        }
    }
}
