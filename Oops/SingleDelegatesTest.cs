using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{

    public delegate void AddDelegate(int a, int b);
     
    public delegate string DisplayDelegate(string str);

    class Mydelegaes
    {
        public void AddNumber(int a, int b)
        {
            Console.WriteLine(a + b);

        }

        public static string Display(string str)
        {
            return "hello" + str;
        }
    }

    internal class SingleDelegatesTest
    {
        static void Main()
        {


            Mydelegaes md = new Mydelegaes();
            AddDelegate ad = new AddDelegate(md.AddNumber);            //method pass as a parameter

            ad(10, 20);

            DisplayDelegate ds = new DisplayDelegate(Mydelegaes.Display);      //method pass as parameter
            string str = ds("helo");
            Console.WriteLine(str);

               


        }
    }
}
