using System.Globalization;

namespace bunny_ass_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var numbers = -1;



            Console.WriteLine("pick a number from 0-5");
            Console.Write("your input: ");

            while (numbers < 0 || numbers > 5) 
            {
                Console.WriteLine("pick a number from 0-5");
                Console.Write("your input: ");
                var input = Console.ReadLine();
                numbers = int.Parse(input);
                
            }
            if (numbers == 5)
            {
                string message = "Bunny ass";
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine(numbers * numbers);
            }
            
          
            
        }

    }
}