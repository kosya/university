using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _2_3_1
{
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
                Console.WriteLine("Write 3 to see all elements of the stack");
                Console.Write("Command number: ");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        {
                            Console.Write("Write an element: ");
                            int tmp = 0;
                            tmp = Convert.ToInt32(Console.ReadLine());
                            stack.Push(tmp);
                            Console.WriteLine("Element was successfully added");
                            break;
                        }
                    case 2:
                        {
                            stack.Pop();
                            Console.WriteLine("Element was successfully deleted");
                            break;
                        }
                    case 3:
                        {
                            if (stack.IsEmpty())
                            {
                                Console.WriteLine("No elements in the stack");
                            }
                            else
                            {
                                Console.WriteLine("Elements of the stack:");
                                stack.PrintStack();
                            }
                            break;
                        }
                }
            }
        }
    }
}
