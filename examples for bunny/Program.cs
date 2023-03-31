namespace examples_for_bunny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloKanin("katt", 5, false);
            Console.ReadLine();
        }

        static void HelloKanin(string fluffybuns, int a, bool IsEndTrueOrFalse)
        {
            
            for (int i = 0; i < a; i++)
            {

                var hmm = IsEndTrueOrFalse ? "!" : "?";
                Console.WriteLine("Hello " + fluffybuns + hmm);
                
            }
        }

        
    }
}