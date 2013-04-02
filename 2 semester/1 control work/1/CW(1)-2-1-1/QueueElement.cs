using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1__2_1_1
{
    public class QueueElement
    {
        public QueueElement Next { get; set; }
        public int Element { get; set; }
        public int Priority { get; set; }

        public QueueElement(QueueElement next, int value, int priority)
        {
            this.Element = value;
            this.Priority = priority;
            this.Next = next;
        }
    }
}
