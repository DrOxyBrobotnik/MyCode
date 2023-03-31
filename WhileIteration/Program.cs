





namespace WhileIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option!");
            Console.WriteLine("Option 1");
            Console.WriteLine("Option 2");
            Console.WriteLine("Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.WriteLine("PrintNumbers");
            Console.Write("type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        } 

        private static void GuessingGame()
        {
            Console.WriteLine("Guessing game!");
            Console.ReadLine();
        }
    }
}