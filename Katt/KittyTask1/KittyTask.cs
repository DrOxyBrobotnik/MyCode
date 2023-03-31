using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KittyTask1
{
    public class KittyTask
    {
        // Returns smallest element of array
        public static int Smallest(int[] array)
        {
            var smallest = array[0];
            foreach (var element in array)
            {
                if (element < smallest)
                    smallest = element;
            }

            return smallest;
        }
    }
}