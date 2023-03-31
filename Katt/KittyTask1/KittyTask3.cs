using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KittyTask1
{
    public class KittyTask3
    {
        // Returns sum of all elements
        public static int Sum(int[] array)
        {
            var total = 0;
            foreach (var item in array)
            {
                total = total + item;
            }

            return total;
        }
    }
}