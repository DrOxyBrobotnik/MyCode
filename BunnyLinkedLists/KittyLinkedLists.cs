using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyLinkedLists
{
    internal class KittyLinkedLists
    {
        private Nodes _head;

        public int Length { get; set; } = 0;

        public void Add(string value)
        {
            var node = new Nodes(value);

            if (_head is null)
            {
                _head = node;
            }
            else
            {
                var lastNode = _head;
                while (lastNode.Next is not null)
                {
                    lastNode = lastNode.Next;
                }
                lastNode.Next = node;
            }

            Length++;

        }
    }
}
