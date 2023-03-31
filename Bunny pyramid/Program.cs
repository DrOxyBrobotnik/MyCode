namespace Bunny_pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BunnyPyramid(5);

            Console.ReadLine();
            

        }

        private static void BunnyPyramid(int numberOfRows)
        {

            for (var row = ; row < numberOfRows; row++)
                Console.Write(new string('*', row));

            
                
                
                
                
                Console.WriteLine();

            }
           

        }
    }
}
