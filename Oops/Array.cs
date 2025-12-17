using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class Array
    {

        public static void Main(String[] args)
        {

            string[] mobile = new string[4];

            //assigning array
            mobile[0] = "Apple";
            mobile[1] = "Sumsumg ";
            mobile[2] = "Viovo";
            mobile[3] = "OnePlues";

            Console.WriteLine("Mobile in array index:");

            for (int i = 0; i < mobile.Length; i++)
            {
                Console.WriteLine(mobile[i]);

            }


            // revers Number 
            int[] Number = { 1, 2, 3, 4 };

            //Print Original 
            Print(Number);

            //reverse string
            Revers(Number);

            Console.WriteLine("Print reverse array");

            Print(Number);




            //Srting  
            string str = "hello Word";
            Console.WriteLine(str);
            str = "test";
            Console.WriteLine(str);

            // this ocure the most space in the memory that why we use the strinbulider in the code , both work are same 
            string fristname = "ram ";
            string lastname = "patil";
            string name = fristname + lastname;
            Console.WriteLine(name);


            //String bulider 
            // append means samply  add in the  string 

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.Append("patil");

            //Remove we wnat any think in the string Builder , 
            sb.Remove(2, 5);



            //Console.WriteLine(result);

            //insert add  in the value after the  specific index, frist we give the index after that index next value be added in that
            sb.Insert(6, "there");

            // Replace the String

            sb.Replace("patil", "C# developer ");
            string result = sb.ToString();

            Console.WriteLine(result.ToString());


            
            //user clear , use of this clear the all the think that ununted storing speces clear that , all lenght are zero 
            //after use of this rest of progrem thaere is no use that we use the clear 
            sb.Clear();


            //boxing 
            int num = 10;   // vlaue type int 
            object obj = num;  // boxing it will convert the value type to object(reference) type 

            //Unboxing 
            object objnew = 34;       // boxing interger value
            int num1 = (int)objnew;    






        }

        public static void Print(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.WriteLine(num + "");

            }
        }

        public static void Revers(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;


            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;

            }
        }

    }
}
