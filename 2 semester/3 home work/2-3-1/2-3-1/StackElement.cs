using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_1
{
    public class StackElement
    {
        public StackElement(StackElement next, int value)
        {
            this.Element = value;
            this.Next = next;
        }

        public int Element { get; private set; }

        public StackElement Next { get; private set; }
    }
}
