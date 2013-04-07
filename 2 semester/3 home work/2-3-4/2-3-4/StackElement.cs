using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_4
{
    public class StackElement
    {
        public int Element { get; set; }

        public StackElement Next { get; set; }

        public StackElement(StackElement next, int value)
        {
            this.Next = next;
            this.Element = value;
        }
    }
}
