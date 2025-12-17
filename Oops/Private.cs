using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
     class Private
    {
        class PrivateClass()
        {
            private int PrivateFiled;

            public void setfiled(int value)
            {
                PrivateFiled = value;

            }

            public void show()
            {
                Console.WriteLine("private filed value" + PrivateFiled);

            }

        }

        public static void Main()
        {
            PrivateClass obj = new PrivateClass();
            obj.setfiled(10);
            obj.show();
        }
    }
}
