using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1__2_1_1
{
    public class Queue
    {
        private int queueMaxPriority = 0;

        private QueueElement head = null;
        private QueueElement tail = null;

        public Queue()
        {
        }
        /// <summary>
        /// Method, which add a new element with its priority.
        /// </summary>
        /// <param name="value">value of the element</param>
        /// <param name="priority">priority of the element</param>
        public void Enqueue(int value, int priority)
        {
            if (tail == null)
            {
                QueueElement tmp = new QueueElement(null, value, priority);
                head = tmp;
                tail = tmp;
                queueMaxPriority = tmp.Priority;
            }
            else
            {
                QueueElement tmp = new QueueElement(null, value, priority);
                tail.Next = tmp;
                tail = tmp;
                if (queueMaxPriority < tmp.Priority)
                {
                    queueMaxPriority = tmp.Priority;
                }
            }
        }
        /// <summary>
        /// Method, which delete the first element with the highest priority of the queue and returns its value
        /// </summary>
        /// <returns>value element</returns>
        public int Dequeue()
        {
            if (head == null)
            {
                throw new EmptyQueueException("Empty Queue");
            }
            QueueElement tmp = head;
            if (tmp.Priority == queueMaxPriority)
            {
                head = head.Next;
                return tmp.Element;
            }
            else
            {
                tmp = tmp.Next;
                QueueElement previousElement = head;
                while (tmp.Priority != queueMaxPriority)
                {
                    previousElement = tmp;
                    tmp = tmp.Next;
                }
                previousElement.Next = tmp.Next;
                return tmp.Element;
            }
        }
        /// <summary>
        /// Method, returns us if queue empty or not
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
