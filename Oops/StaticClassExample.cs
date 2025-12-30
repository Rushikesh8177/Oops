using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Oops
{

    //static class
    static class Product
    {

        //static Members
        public static int productid;
        public static string productname;
        public static int productPrice;

        //static Constructor
        static Product()
        {
            productid = 1;
            productname = "Hello";
            productPrice = 100;

        }

        //static method
        public static void GetProductDetails()
        {
            Console.WriteLine($"ProductId: {productid}");
            Console.WriteLine($"ProductName: {productname}");
            Console.WriteLine($"ProductSize: {productPrice}");

        }

        public static void GetDisccount()
        {
            int D_amount = productPrice / 10;
            Console.WriteLine($"Discounnt amout is: {D_amount}");
            Console.WriteLine($"Total amount is : {(productPrice - D_amount)}");


        }
    }


  
    internal class StaticClassExample
    {
        
        static void Main()
        {
            //Product pt = new Product();  we can not create the instnces directly of static method 

            Product.GetProductDetails();
            Product.GetDisccount();
            Console.ReadLine();


        }

    }
}
