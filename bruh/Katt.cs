using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bruh
{
    
    public class Katt
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Katt(string name, int age)
        {
            Name = name;
            Age = age;
        }


        
        public void Meow()
        {
            Console.WriteLine("\"Meow!\" said" + Name + Katt.g);
        }

        private string GetAge()
        {
            if (Age >= 34)
            {
                return "Old";
            }

            else return "Young";
        }

    }
}
