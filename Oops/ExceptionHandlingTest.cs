using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    internal class ExceptionHandlingTest
    {
        static void Main()
        {
            int[] number = { 1, 2, 3 };
            int index = 3;

            try
            {
                int value = number[index];
                Console.WriteLine($"value at index {index} is : {value}");

            }
            catch ( IndexOutOfRangeException e)
            {
                Console.WriteLine($"Error :{e.Message} ");

            }
            catch (Exception e)               // Exception is a comman it is it through whatwver exception this give in the result
            {
                Console.WriteLine($"Error: {e.Message}");

            }
            finally
            {
                Console.WriteLine("This Code always excute");
            }


            //Divide by Zero

            int num = 10;
            int demo = 0;
            double result;

            try
            {
                result = num / demo;
                Console.WriteLine($"Result of division :{result}");

            }catch(DivideByZeroException e)
            {
                Console.WriteLine($"Error : {e.Message}");

            }
            finally
            {
                Console.WriteLine("h");
                
            }
            

            //Coustome Exception 

            try
            {
                dataprocessing(null);

            }catch (Exception e){
                Console.WriteLine($"Error : {e.Message}");

            }

            static void dataprocessing(string data)
            {
                if(data == null)
                {
                    throw new ArgumentNullException(nameof(data), "data cannot be null");

                }
            }



        }
    }
}
