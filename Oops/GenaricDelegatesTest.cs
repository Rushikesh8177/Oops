using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
 
    internal class GenaricDelegatesTest
    {

        // func delegate
        public static double AddNumber(int a, float b , double c)
        {
            return a + b + c;
        }

        public static void Addnumber2(int a, float b, double c)
        {
            Console.WriteLine(a + b + c);           // it doest accept the retun type 

        }

        public static bool checkNumber(string str)
        {
            if (str.Length > 5)
                return true;
            else
                return false;

        
        }

        static void Main()
        {
            // func delegate

            Func<int, float, double ,double> obj = AddNumber;
            double result = obj.Invoke(10, 20, 30.4);
            Console.WriteLine(result);



            //Action delegate in that deleagte we add max 16 parameters but it dont return any value
            Action<int, float, double > obj2 = Addnumber2;
            obj2.Invoke(20, 45, 55.5);


            //Predicate Delegate    it always return bool value and it take only one parameter 

            Predicate<string> obj3 = checkNumber;
            bool res = obj3.Invoke("Hello");
            Console.WriteLine(res);



             
         


        }
    }
}
