using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class DictionaryTest
    {
        static void Main()
        {
            // in the string and int are our choose dataype if we want to change we can change it 

            Dictionary<string, int> agedis = new Dictionary<string, int>();

            // add key value pair
            agedis.Add("Rhit", 28);
            agedis.Add("Shubham", 25);
            agedis.Add("Ankush", 30);
            agedis.Add("Sumit", 27);

            //Print the Dictionary
            Console.WriteLine("Dictionary Element");

            foreach(KeyValuePair<string , int> kvp in agedis)
            {
                Console.WriteLine($"{kvp.Key} :{kvp.Value}");

            }

            //modify dict
            agedis["Rhit"] = 30;
            //Print modify the Dictionary
            Console.WriteLine("Dictionary modifiy Element");

            foreach (KeyValuePair<string, int> kvp in agedis)
            {
                Console.WriteLine($"{kvp.Key} :{kvp.Value}");

            }

            //Remove in the dic
            agedis.Remove("Sumit");


            //search Item in dic
            if (agedis.ContainsKey("Ankush"))
            {
                Console.WriteLine("Exites in dic ");

            }

            agedis.Clear();
            Console.WriteLine(agedis.Count());
        }
     }
}
