namespace KattsInterfaceAttempt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kattwhat meow = new Kattwhat();

            meow.KattKnowledge = "Growing";
            meow.KattEnergy = "So-so";
            meow.KattSleepy = "A little sleepy";
            
            Console.WriteLine($"My learning today is {meow.KattKnowledge}, my energy is {meow.KattEnergy}, and I'm {meow.KattSleepy}");
        }
    }
}