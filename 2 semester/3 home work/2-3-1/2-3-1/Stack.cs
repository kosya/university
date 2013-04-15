using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_1
{
    public class Stack
    {
        private StackElement head = null;

        public Stack()
        {
        }

        /// <summary>
        /// Method, which adds a new element in the stack
        /// </summary>
        /// <param name="value">value of the element</param>
        public void Push(int value)
        {
            StackElement tmp = new StackElement(head, value);
            head = tmp;
        }
        
        /// <summary>
        /// Method, which returns value of deleted element from the stack
        /// </summary>
        /// <returns>value of the deleted element</returns>
        public int Pop()
        {
            if (!IsEmpty())
            {
                int result = head.Element;
                head = head.Next;
                return result;
            }
            else
            {
                throw new NullReferenceException("No Elements in the stack");
            }
        }

        /// <summary>
        /// Method, which prints all elements of the stack
        /// </summary>
        public void PrintStack()
        {
            StackElement tmp = head;
            while (tmp != null)
            {
                Console.WriteLine("{0}", tmp.Element);
                tmp = tmp.Next;
            }
        }

        /// <summary>
        /// Method, which shows us if stack is empty or not.
        /// </summary>
        /// <returns>if stack is empty then returns "true" else returns "false"</returns>
        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
