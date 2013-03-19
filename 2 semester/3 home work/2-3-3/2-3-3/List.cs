using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_3
{
    class ListElement
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
                head = tmp;
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
                tail = tmp;
            }
        }

        public void DeleteElement(int value)
        {
            if (head != null)
            {
                if (head.next != null)
                {
                    ListElement tmp = head;
                    while (tmp.next.element != value && tmp != null)
                    {
                        tmp = tmp.next;
                    }
                    if (tmp == null)
                    {
                        Console.WriteLine("This element doesn't exist");
                    }
                    else
                    {
                        tmp.next = tmp.next.next;
                        Console.WriteLine("Element was successfully deleted");
                    }
                }
                else
                {
                    if (head.element == value)
                    {
                        head = null;
                        Console.WriteLine("Element was successfully deleted");
                    }
                    else
                    {
                        Console.WriteLine("This element doesn't exist");
                    }
                }
            }
            else
            {
                Console.WriteLine("This element doesn't exist");
            }
        }

        public void PrintList()
        {
            if (head != null)
            {
                ListElement tmp = head;
                while (tmp != null)
                {
                    Console.Write("{0} ", tmp.element);
                    tmp = tmp.next;
                }
            }
        }

        public bool SearchElement(int value)
        {
            if (head != null)
            {
                ListElement tmp = head;
                while (tmp.element != value && tmp.next != null)
                {
                    tmp = tmp.next;
                }
                if (tmp.element == value)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}