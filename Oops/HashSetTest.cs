using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class HashSetTest
    {
        static void Main()
        {
            HashSet<int> num = new HashSet<int>();

            // add element
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);
            num.Add(5);
            num.Add(3); // duplicate value will be ignored

            Console.WriteLine("HashSet Elements:");
            foreach(int item in num)
            {
                Console.WriteLine(item);
            }

            // Find particular element in hashset

            bool containsTwo = num.Contains(2);
            Console.WriteLine("HasSet contains 2 : " + containsTwo);

            //remove element in hasset
            num.Remove(3);
            Console.Write("After Remove : ");

            foreach(int item in num)
            {
                Console.WriteLine(item);

            }

            HashSet<int> has = new HashSet<int> { 1, 2, 3, 4, 5 };

            
            num.UnionWith(has);              // unionWith meas add two hasset 
            foreach (int item in num)
            {
                Console.WriteLine(item);

            }


        }
    }
}
