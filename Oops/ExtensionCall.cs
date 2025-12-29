using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class ExtensionCall
    {
        static void Main()
        {

            ExtensionMethodOld ext = new ExtensionMethodOld();

            ext.Test1();
            ext.Test2();


            //This test is in the new file but we call it here beacuse of this keyword , "this"  extened method form old to new 
            ext.Test3();
            ext.Test4(10);
            ext.Test5();


        }

    }
}
