using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2
{
    public class List
    {
        protected ListElement head = null;
        protected ListElement tail = null;

        public List()
        {
        }

        /// <summary>
        /// Method, which adds a new element in the list
        /// </summary>
        /// <param name="value">value of an element</param>
        public virtual void AddElement(int value)
        {
            if (IsEmpty())
            {
                ListElement tmp = new ListElement(null, value);
                head = tmp;
                tail = tmp;
            }
            else
            {
                ListElement tmp = new ListElement(null, value);
                tail.Next = tmp;
                tail = tmp;
            }
        }

        /// <summary>
        /// Method, which deletes an element from the list
        /// </summary>
        /// <param name="value">value of the element, which is wanted to be deleted</param>
        /// <returns>value of deleted element</returns>
        public int DeleteElement(int value)
        {
            if (!IsEmpty())
            {
                if (head.Next != null)
                {
                    if (head.Element == value)
                    {
                        head = head.Next;
                        return value;
                    }
                    ListElement tmp = head;
                    while (tmp.Next.Element != value && tmp != null)
                    {
                        tmp = tmp.Next;
                    }
                    if (tmp == null)
                    {
                        throw new ExistenceException("This element doesn't exist");
                    }
                    else
                    {
                        tmp.Next = tmp.Next.Next;
                        return tmp.Element;
                    }
                }
                else
                {
                    if (head.Element == value)
                    {
                        int tmp = head.Element;
                        head = null;
                        return tmp;
                    }
                    else
                    {
                        throw new ExistenceException("This element doesn't exist");
                    }
                }
            }
            else
            {
                throw new EmptyListException("This element doesn't exist");
            }
        }

        /// <summary>
        /// Method, which prints all elements of the list
        /// </summary>
        public void PrintList()
        {
            if (!IsEmpty())
            {
                ListElement tmp = head;
                while (tmp != null)
                {
                    Console.Write("{0} ", tmp.Element);
                    tmp = tmp.Next;
                }
            }
        }

        /// <summary>
        /// Method, which searches element in the list
        /// </summary>
        /// <param name="value">value of the required element</param>
        /// <returns>if element is in the list trhen returns "true" else returns "false"</returns>
        public bool SearchElement(int value)
        {
            if (!IsEmpty())
            {
                ListElement tmp = head;
                while (tmp.Element != value && tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                return tmp.Element == value;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Method, which shows us if list is empty or not
        /// </summary>
        /// <returns>if list is empty then returns true else returns false</returns>
        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
