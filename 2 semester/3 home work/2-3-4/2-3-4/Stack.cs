using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_4
{
    public class Stack: IStack
    {
        private int amountOfElements = 0;
        private StackElement head = null;

        public void Push(int value)
        {
            StackElement tmp = new StackElement(head, value);
            head = tmp;
            amountOfElements++;
        }

        public int Pop()
        {
            if (head != null)
            {
                int tmp = head.Element;
                amountOfElements--;
                head = head.Next;
                return tmp;
            }
            else
            {
                return 0;
            }
        }

        public int AmountOfElements()
        {
            return amountOfElements;
        }
    }
}