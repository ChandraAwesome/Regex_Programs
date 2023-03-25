using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Exceptionss
    {
        public static void Errors()
        {
            
            try
            {
                Console.WriteLine("Enter the input ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 10)
                {
                    throw new MyException("You entered the wrong input buddy");
                }
                int x = 10;
                int result = x / input;
                Console.WriteLine(result);
                
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (MyException e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Done");
        }
    }

    class MyException : Exception
    {
        public MyException(string message) : base(message) 
        {
        }
    }
}
