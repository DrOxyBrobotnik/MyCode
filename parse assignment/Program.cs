namespace parse_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var input = 0;
            

           
            


            while (input < 0 || input > 5)
            {
                Console.WriteLine("Type in a number 0 to 5");
                Console.Write("your input:");

                Console.ReadLine();
            }

            string response;
            if (input == "katt")
                response = "nya";
            else
                response = "pyon";

            Console.WriteLine(response);

        }
    }
}