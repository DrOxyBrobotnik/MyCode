using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyTesting
{
    public class KittyClass
    {

     

        public KittyClass(string[] kattstuff)
        {
            
        }

        private string _katt;

        public static void KittyMethod(string[] kittyArray)
        {
            foreach (var item in kittyArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
