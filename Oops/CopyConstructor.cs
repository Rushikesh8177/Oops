using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{

    public class CopyConstructorExample
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string NewName { get; set; }

        public int  NewAge { get; set;}

        public CopyConstructorExample(string name, int age)
        {
            Name = name;
            Age = age;

        }

        // copy Constructor
        public CopyConstructorExample(CopyConstructorExample copyex)
        {
            NewName = copyex.Name;
            NewAge = copyex.Age;
           

        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}, Age :{Age}");
            Console.WriteLine($"Newname : {NewName} , NewAge: {NewAge}");  

        }
    }
    internal class CopyConstructor
    {
        static void Main()
        {
            CopyConstructorExample obj = new CopyConstructorExample("Hello", 36);
            obj.DisplayInfo();

            // create another obj for the copy constructor
            CopyConstructorExample ob = new CopyConstructorExample(obj);
            ob.DisplayInfo();
        }
    }
}
