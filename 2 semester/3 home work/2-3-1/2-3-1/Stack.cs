using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_1
{
    class StackElement
    {
        public int element;
        public StackElement next;
    }

    class Stack
    {
        public StackElement head = null; 

        public void Push(int value)
        {
            StackElement tmp = new StackElement();
            tmp.element = value;
            tmp.next = head;
            head = tmp;
            Console.WriteLine("Element was successfully added");
        }

        public void Pop()
        {
            if (head != null)
            {
                head = head.next;
                Console.WriteLine("Element was successfully deleted");
            }
            else
            {
                Console.WriteLine("No elements in the stack");
            }
        }

        public void PrintStack()
        {
            StackElement tmp = head;
            if (tmp == null)
            {
                Console.WriteLine("No elements in the stack");
            }
            else
            {
                Console.WriteLine("Elements of the stack:");
                while (tmp != null)
                {
                    Console.WriteLine("{0}", tmp.element);
                    tmp = tmp.next;
                }
            }
        }
    }
}
