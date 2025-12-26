using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class NonGenStack
    {
        static void Main()
        {

            // create non gen stack 
            //work last-in frist-out 
            Stack sk = new Stack();

            // for add in stack use push 
            sk.Push(100);
            sk.Push("wlcome");
            sk.Push(false);

            // for remove we use Pop 

            Console.WriteLine("Pop element");
            object topelement = sk.Pop();
            object secondelement = sk.Pop();
            object thirdelemnt = sk.Pop();

            Console.WriteLine(topelement);
            Console.WriteLine(secondelement);
            Console.WriteLine(thirdelemnt);

            Console.WriteLine("Stack is empty" +(sk.Count==0));




        }
    }
}
