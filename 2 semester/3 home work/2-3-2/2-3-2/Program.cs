using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _2_3_2
{
    class List
    {
        IntPtr pointer;
        private int count = 0;
        private int range = 10;
        private int head = 0;

        public List()
        {
            pointer = Marshal.AllocHGlobal(sizeof(int) * range);
        }

        ~List()
        {
            Marshal.FreeHGlobal(pointer);
        }

        public void Push(int element)
        {
            if (count == range)
            {
                range += 10;
                pointer = Marshal.ReAllocHGlobal(pointer, (IntPtr)(sizeof(int) * (head + range)));
            }
            count++;
            Marshal.WriteInt32(pointer, sizeof(int) * count, element);
        }

        public void Pop()
        {
            if (head != count)
            {
                head++;
            }
        }

        public void Peek()
        {
            int value = Marshal.ReadInt32(pointer, sizeof(int) * (head + 1));
            Console.WriteLine("The head element of the list: {0}", value);
        }

        public void PrintList()
        {
            Console.WriteLine("Elements of the list:");
            if (count == head)
            {
                Console.WriteLine("No elements in the list");
            }
            else
            {
                for (int i = head + 1; i <= count; ++i)
                {
                    int value = Marshal.ReadInt32(pointer, sizeof(int) * i);
                    Console.Write("{0} ", value);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();

            int command = -1;
            while (command != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Write 0 to exit");
                Console.WriteLine("Write 1 to add an element to the list");
                Console.WriteLine("Write 2 to delete an element from the list");
                Console.WriteLine("Write 3 to see the head element of the list");
                Console.WriteLine("Write 4 to see all elements of the list");
                Console.Write("Command number: ");
                command = Convert.ToInt32(Console.ReadLine());
                if (command == 1)
                {
                    Console.Write("Write an element: ");
                    int tmp = 0;
                    tmp = Convert.ToInt32(Console.ReadLine());
                    list.Push(tmp);

                }
                else if (command == 2)
                {
                    list.Pop();
                }
                else if (command == 3)
                {
                    list.Peek();
                }
                else if (command == 4)
                {
                    list.PrintList();
                }
            }
        }
    }
}
