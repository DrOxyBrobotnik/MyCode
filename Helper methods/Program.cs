using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7a_HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //before using helper methods

            Console.WriteLine("The Name Game");
            

            Console.Write("What's your first name? ");
            string fName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lName = Console.ReadLine();

            Console.Write("What's your city? ");
            string city = Console.ReadLine();

          
            
            

            DisplayResult(ReverseString(fName),
                ReverseString(lName),
                ReverseString(city));

            Console.WriteLine();
            Console.WriteLine();

            DisplayResult(ReverseString(fName) + " " +
                ReverseString(lName) + " " +
                ReverseString(city)); 


            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {
            
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return string.Concat(messageArray);
        }

        private static void DisplayResult(
        string reversedFirstname,
        string reversedLastname,
        string reversedCity)
        {
            Console.WriteLine("Results ");
            Console.Write(String.Format("{0} {1} {2}",
           reversedFirstname,
           reversedLastname,
           reversedCity));
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine("Results ");
            Console.Write(message);
        }
    }
}