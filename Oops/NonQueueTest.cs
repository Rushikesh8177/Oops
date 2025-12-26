using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class NonQueueTest
    {
        static void Main()
        {
            Queue qu = new Queue();
            //Frist-in frist-out follows   

            //Enqueue is used for adding element in the queues

            qu.Enqueue("java");
            qu.Enqueue(55545455);
            qu.Enqueue(true);

            //deque - to remove element
            object fristelement = qu.Dequeue();
            object secondelement = qu.Dequeue();
            object thiedelement = qu.Dequeue();



            //Display item 
            Console.WriteLine("Dequese element");
            Console.WriteLine(fristelement);
            Console.WriteLine(secondelement);
            Console.WriteLine(thiedelement  );

        }
    }
}
