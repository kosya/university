using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_2
{
    public class ListElement
    {
        public int Element { get; set; }
        public ListElement Next { get; set; }

        public ListElement(ListElement next, int value)
        {
            this.Next = next;
            this.Element = value;
        }
    }
}
