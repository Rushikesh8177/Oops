using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Oops
{
    internal class ArrayListTest
    {

        static void Main()
        {


            //Creating ArrayList 
            ArrayList lis = new ArrayList();

            //Adding elements to arraylist 

            lis.Add(1);
            lis.Add("Wlwcome");
            lis.Add(false);

            //Access to element 
            Console.WriteLine("ArrayList Element");

            foreach(var  item in lis)
            {
                Console.WriteLine(item);

            }

            //Remove item at any time 
            lis.RemoveAt(1);            //RemoveAt is used at specifiec remove at index 
            lis.Remove(false);
            Console.WriteLine("ArrayList Elemnt");

            foreach(var item in lis)
            {
                Console.WriteLine(item);

            }




        }

    }
}
