using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Oops
{
    public static  class ExtensionMethodNew
    {
        public static void Test3(this ExtensionMethodOld o)
        {
            Console.WriteLine("Three Method");

        }

        public static void Test4(this ExtensionMethodOld o, int x)
        {
            Console.WriteLine("Four Method" + x);
        }

        public static void Test5(this ExtensionMethodOld o)
        {
            Console.WriteLine("Five Methos");
        }

    }
}
