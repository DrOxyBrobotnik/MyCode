using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KittyTask1
{
    public class KittyTask2
    {
        // Returns true if array contains value, otherwise false
        public static bool Contains(int[] array, int value)
        {
            foreach (var item in array)
            {

                if (item == value)
                    return true;

                



            }
            return false;
        }
    }
}