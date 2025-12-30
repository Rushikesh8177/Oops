using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class OutExample
    {
        static void Main()
        {
            //declare variables with output 
            int result1, result2, result3, result4;
            int x, y;

            //call method with  out parameters
            Calculate(10, 5, out result1, out result2, out result3, out result4);

            //reulta diaplay
            Console.WriteLine($"Addition: {result1}");
            Console.WriteLine($"Subtraction: {result2}");
            Console.WriteLine($"Multiplication: {result3}");
            Console.WriteLine($"Division: {result4}");


        }

        static void Calculate(int a, int b, out int sum, out int diff, out int prod, out int quot)
        {
            sum = a + b;
            diff = a - b;
            prod = a * b;
            quot = a / b;
        }
    }
}
