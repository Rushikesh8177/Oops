using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class HashTableTest
    {
        static void Main()
        {
            Hashtable has = new Hashtable();

            // add key value pair

            has.Add(101, "java");
            has.Add(102, "Dotnet");
            has.Add(103, 122);
            has.Add(104, true);

            //accsessing element throught typecasting

            string value1 = (string)has[101];
            string value2 = (string)has[102];
            string value3 = Convert.ToString((int)has[103]);
            bool value4 = (bool)has[104];

            //Display value

            Console.WriteLine($"101:{value1}");
            Console.WriteLine($"102:{value2}");
            Console.WriteLine($"103:{value3}");
            Console.WriteLine($"104:{value4}");

        }
    }
}
