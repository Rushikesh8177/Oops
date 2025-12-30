using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class RefExxample
    {

        public static void swap(ref int a , ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }
        static void Main()
        {
            int x = 10;
            int y = 20;

            Console.WriteLine($"Before swap : x={x}, y={y}");
            swap(ref x, ref y); // pass by reference using ref keyword
            Console.WriteLine($"After swap : x={x}, y={y}");


        }
    }
}
