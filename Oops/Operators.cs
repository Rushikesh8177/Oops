using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Operators
    {
        public static void Main()
        {
            //artimatic operators
            int a = 10;
            int b = 30;

            Console.WriteLine("Arthimatic operators");

            Console.WriteLine($" a + b ={a +b}");
            Console.WriteLine($" a * b ={a * b}");
            Console.WriteLine($" a / b ={a / b}");
            Console.WriteLine($" a - b ={a - b}");
            Console.WriteLine($" a % b ={a % b}");


            //Releaction Operators
            Console.WriteLine("Releaction Operators");

            Console.WriteLine($" a==b : {a == b}");
            Console.WriteLine($" a !=b : {a != b}");
            Console.WriteLine($" a > b   : {a > b}");
            Console.WriteLine($" a > b : {a > b}");
            Console.WriteLine($" a >=b : {a >= b}");
            Console.WriteLine($" a<=b : {a  <= b}");


            //Logical Operators
            bool x = true;
            bool y = false;

            Console.WriteLine("Logical Operators");
            Console.WriteLine($" x && y  : {x && y}");
            Console.WriteLine($" x || y  : {x || y}");
            Console.WriteLine($" !x  : { !x}");



        }
    }
}
