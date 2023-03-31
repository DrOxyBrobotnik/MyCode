using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyLinkedLists
{
    public class Nodes
    {

        public string Value { get; set; }
        public int Length { get; set; } = 0;

        public Nodes Next { get; set; }
        public Nodes Previous { get; set; }

        public Nodes(string value)
        {
            Value = value;
        }

        
    }
}
