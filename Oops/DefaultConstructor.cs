using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    public class DefaultConstructorExample
    {
        public int value;

        //Default Constructore
        public DefaultConstructorExample()
        {
            value = 1;

        }

        // create new methos that we need to call 

        // in that method must be the return type,,... mens void is compsory
        public void Test()
        {
            Console.WriteLine("Test" + value);  //
        }
    }



    internal class DefaultConstructor
    {
        public static void Main()
        {
            DefaultConstructorExample e = new DefaultConstructorExample();
            Console.WriteLine(e.value);

            e.Test();

        }
    }
}
