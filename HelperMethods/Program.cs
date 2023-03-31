﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _7a_HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.WriteLine("The Name Game");

            
            Console.Write("What's your first name? ");
            string fName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lName = Console.ReadLine();

            Console.Write("What's your city? ");
            string city = Console.ReadLine();

            /*

            char[] fNameArray = fName.ToCharArray();
            Array.Reverse(fNameArray);

            char[] lNameArray = lName.ToCharArray();
            Array.Reverse(lNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach (char item in fNameArray)
            {
                result += item;
            }

            foreach (char item in lNameArray)
            {
                result += item;
            }

            foreach (char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Results: " + result);
            */

            Console.Write("Results: ");
            ReverseString(fName);
            ReverseString(lName);
            ReverseString(city);

            Console.ReadLine();
        
        }

        private static void ReverseString(string message)
        {
            
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write("");
        }
    }
}