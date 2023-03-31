using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KittyTests
{
    public class KittyClass
    {

        

        public KittyClass(string[] kattstuff)
        {
            
        }

        private static string _katt;

        

       
        
        public static void KittyMethod(string[] kittyArray)
        {

            _katt = kittyArray[0];

            foreach (var item in kittyArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}