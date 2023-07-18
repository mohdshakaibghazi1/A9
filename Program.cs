using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9

{
    public class ValidationException : Exception
    {
        public ValidationException(string message):base(message) {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
            Console.WriteLine("enter Your name");
           var Name=Console.ReadLine();
            Console.WriteLine("enter Your Email Address");
            var Email = Console.ReadLine();
            Console.WriteLine("enter Your Password");
            var Password = Console.ReadLine();
            int l1 = Name.Length;
            int l2 = Password.Length;
                if (l1 < 6)
                {
                    throw new ValidationException($"Error{Name} invalid ,Name should be 6 digit");
                }
               else if (l2 < 8)
                {
                    throw new ValidationException($"Error{Password} invalidPassword should be 8 digit");
                }
                else 
                {
                    Console.WriteLine("valiadation successfull");
                    Console.WriteLine("your Details are");
                    Console.WriteLine("____________________________________");
                    Console.WriteLine($"Name:\t{Name}\n Email:\t{Email}\n Password:\t{Password}");
                    Console.WriteLine("____________________________________");

                }

            }
            catch (ValidationException v) { Console.WriteLine("validation error" + v.Message); }
            catch (Exception e) { Console.WriteLine( "error"+e.Message); }
            finally { Console.WriteLine("validation Completed");
            }
            
        }
    }
}
