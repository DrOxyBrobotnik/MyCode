using System.Text;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //substring is used as a starting point in
            //a string or starting point and then length
            //and can as such only contain two values
            //string myString = "My \"so-called\" life";
            //string myString = "What if I need a\nnew line?";
            //string myString = "Go to yóur c:\\ drive";
            //string myString = @"Go to your c:\ drive";

            //string myString = String.Format("{1} = {0}", "First", "Second");

            //string myString = string.Format("{0:C}", 123.45);
            //string myString = string.Format("{0:N}", 1234567890);
            //string myString = string.Format("Percentage: {0:P}", .123);
            //string myString = string.Format("Phone Number: {0:(###) ###-####}", 123456789012);
            //string myString = "Scream all you like, your gods can't hear you";
            //myString = myString.Substring(8, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);


            /*
            myString = String.Format("Length before: {0} -- Length after: {1}",
            myString.Length, 
            myString.Trim().Length);
            */

            /*
            string myString = " ";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            /*
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
            

            /*var list = Enumerable.Range(0, 100);
            var myString = string.Join("--", list);

            */

            var katt = new StringBuilder();
            for (var i = 0; i < 1_000_000; i++)
                katt.AppendLine("meow");

            var result = katt.ToString();


            Console.WriteLine(katt);
            Console.ReadLine();

           
        }
    }
}