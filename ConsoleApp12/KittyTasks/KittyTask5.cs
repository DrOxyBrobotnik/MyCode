using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace KittyTask
{
    public class KittyTask5
    {
        /* Check if age is between 18 and 33 (both inclusive) and assign result to 'result'.
         */
        public bool Invoke(int age)
        {
            var result = false;

            // to make equal to or lesser than one number, just copy the below code but remove && and everything after it

            result = 18 <= age && age <= 33;

            return result;
        }
    }
}
