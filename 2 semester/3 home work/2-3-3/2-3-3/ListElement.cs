using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_3
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
