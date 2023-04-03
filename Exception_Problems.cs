using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataStructures.Exception_Assignment
{
    public class Exception_Problems
    {
        public  void Age(int age)
        {

            try
            {
                
               // Console.WriteLine("Enter your Age : ");
               // string input = Console.ReadLine();

               // //
               // //string correctformat = "^[0-9]+$";
               // //if(!Regex.IsMatch(correctformat,input))
               //if (input =="" || input==null)
               // {
               //     throw new MyAgeException("You didn't entered corret information. Check Once.");
               // }
               // //
               // Console.WriteLine("Now enter the input in Numbers");
               // int age = Convert.ToInt32(Console.ReadLine());
                
                if (age >= 1 || age <= 14)
                {
                    Console.WriteLine("This person comes under Children Catagory");
                }
                else if (age >= 15 || age <= 24) { Console.WriteLine("This person comes under Youth Catagory"); }
                else if (age >= 25 || age <= 64) { Console.WriteLine("This person comes under Adult Catagory"); }
                else { Console.WriteLine("This person comes under Senior Catagory"); }
            }
            catch (FormatException e)
            {
                string msg = "Enter the input in numbers";
                Console.WriteLine("Custom message"+msg);
                Console.WriteLine("System Exception"+e.Message);
            }
            catch (MyAgeException e )
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class MyAgeException : Exception
    {
        public MyAgeException(string message):base(message) { }
    }
}
