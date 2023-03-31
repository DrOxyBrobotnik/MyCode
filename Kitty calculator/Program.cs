using System.Linq.Expressions;

internal class Program
{
    static void Main(string[] args)
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your operator(+, -, /, *)");
        var myOperator = string.Empty;





        while (myOperator != "+" &&
            myOperator != "-" &&
            myOperator != "/" &&
            myOperator != "*" ||
            (myOperator == "/" && y == 0))

        {
            Console.WriteLine("Please choose a valid operand");
            myOperator = Console.ReadLine();
        }




        if (myOperator == "+")

            Console.WriteLine(x + y);


        if (myOperator == "-")

            Console.WriteLine(x - y);


        if (myOperator == "*")

            Console.WriteLine(x * y);


        if (myOperator == "/")

            Console.WriteLine(x / y);
    }
}




    
