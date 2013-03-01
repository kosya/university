using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _2_3_1
{
    public class Stack
    {
        IntPtr pointer;
        int count = 0;

        int range = 10;

        public Stack()
        {
            pointer = Marshal.AllocHGlobal(sizeof(int) * range);
        }

        ~Stack()
        {
            Marshal.FreeHGlobal(pointer);
        }

        public void Push(int element)
        {
            if (count == range)
            {
                range += 10;
                pointer = Marshal.ReAllocHGlobal(pointer, (IntPtr)(sizeof(int) * (range)));
            }
            Marshal.WriteInt32(pointer, sizeof(int) * count++, element);
        }

        public void Pop()
        {
            if (count != 0)
            {
                count--;
                range--;
                pointer = Marshal.ReAllocHGlobal(pointer, (IntPtr)(sizeof(int) * (range)));
            }
        }

        public void Peek()
        {
            if (count == 0)
            {
                Console.WriteLine("No elements in the stack");
            }
            else
            {
                int value = Marshal.ReadInt32(pointer, sizeof(int) * (count - 1));
                Console.WriteLine("The head element of the stack: {0}", value);
            }
        }

        public void PrintStack()
        {
            if (count != 0)
            {
                Console.WriteLine("Elements of the stack:");
                IntPtr tmpPtr = pointer;
                int tmp = count;
                while (tmp != 0)
                {
                    int value = Marshal.ReadInt32(pointer, sizeof(int) * (tmp - 1));
                    Console.Write("{0} ", value);
                    tmp--;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No elements in the stack");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            int command = -1;
            while (command != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Write 0 to exit");
                Console.WriteLine("Write 1 to add an element to the stack");
                Console.WriteLine("Write 2 to delete an element from the stack");
                Console.WriteLine("Write 3 to see the head element of the stack");
                Console.WriteLine("Write 4 to see all elements of the stack");
                Console.Write("Command number: ");
                command = Convert.ToInt32(Console.ReadLine());
                if (command == 1)
                {
                    Console.Write("Write an element: ");
                    int tmp = 0;
                    tmp = Convert.ToInt32(Console.ReadLine());
                    stack.Push(tmp);
                    
                }
                else if (command == 2)
                {
                    stack.Pop();
                }
                else if (command == 3)
                {
                    stack.Peek();
                }
                else if (command == 4)
                {
                    stack.PrintStack();
                }
            }
        }
    }
}
