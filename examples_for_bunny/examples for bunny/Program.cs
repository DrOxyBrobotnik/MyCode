using System;

namespace CSharpExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "apple", "banana", "cherry", "mango" };
            string searchElement = "guava";
            bool exists = Array.Exists(arr, element => element == searchElement);
            if (exists)
            {
                Console.WriteLine("Array contains specified element.");
            }
            else
            {
                Console.WriteLine("Array does not contain specified element.");
            }
        }
    }
}