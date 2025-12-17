using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class Readonlyex
    {
        public readonly int initialvalue;
        public static readonly double pi;

        public Readonlyex(int inti)
        {
            initialvalue = inti;
            initialvalue = 20;


        }

        static Readonlyex()
        {
            pi = 3.14158;

        }

      
        public void Printvalue()
        {
            Console.WriteLine($"Initial value : {initialvalue}");
            Console.WriteLine($"value of pi : {pi}");
        }
        
    }


    internal class Readonly
    {
        static void Main()
        {
            Readonlyex read = new Readonlyex(10  );
            read.Printvalue();

        }
    }
}
