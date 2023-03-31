





namespace Bunny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bunny molest program");
            Console.Write("Bunny is: afk, present, or sleeping: ");
            string userValue = Console.ReadLine();

            string message = "No";
            if (userValue == "afk")
                message = "Grab that bunny ass :3";   
              else if (userValue == "present")
                message = "Suck the milk out off those bunny milkers!";
            else if  (userValue == "sleeping")
                message = "cooooom...";             
            Console.WriteLine("\n" + message);
        }
    }
}
