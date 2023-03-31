namespace the_fucking_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userValue = string.Empty;
            while (userValue != "katt" && userValue != "kanin")
            {
                Console.WriteLine("Type in katt or kanin for a nice reward");
                Console.Write("Your input: ");

                userValue = Console.ReadLine();
            }

            string response;
            if (userValue == "katt")
                response = "nya";
            else 
                response = "pyon";

            Console.WriteLine(response);
            
          

            

            
        }
    }
}