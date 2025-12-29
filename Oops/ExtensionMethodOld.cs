using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Oops
{
    public  class ExtensionMethodOld
    {

        public int x = 100;

        public  void Test1()
        {
            Console.WriteLine("Frist Method" + this.x);
        }

        public  void Test2()
        {
            Console.WriteLine("Second Method" +this.x);
        }
    }
}
