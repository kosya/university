using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_2
{
    class Listelement
    {
        public int element;
        public ListElement next;
    }

    class List
    {
        public ListElement head = null;
        public ListElement tail = null;

        public void Push(int value)
        {
            if (head == null)
            {
                ListElement tmp = new ListElement();
                ListElement head = tmp;
                tmp.next = null;
                tmp.element = value;
                tail = tmp;
            }
            else
            {
                ListElement tmp = new ListElement();
                tmp.element = value;
                tmp.next = null;
                tail.next = tmp;
            }
        }

        public void Pop()
        {
            if (head != null)
            {
                head = head.next;
            }
            else
            {
                Console.WriteLine("No elements in the list");
            }
        }

        public void PrintList()
        {
            Console.WriteLine("Elements of the list");
            ListElement tmp = head;
            while (tmp != null)
            {
                Console.Write("{0} ", tmp.element);
                tmp = tmp.next;
            }
        }
    }
}
