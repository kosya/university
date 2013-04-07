using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace _2_3_2
{
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
                Console.WriteLine("Write 2 to see all elements of the list");
                Console.WriteLine("Write 3 to delete the first specific element");
                Console.WriteLine("Write 4 to search for the element in the list");
                Console.Write("Command number: ");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        {
                            Console.Write("Write an element: ");
                            int tmp = 0;
                            tmp = Convert.ToInt32(Console.ReadLine());
                            list.AddElement(tmp);
                            break;
                        }
                    case 2:
                        {
                            list.PrintList();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Write an element: ");
                            int tmp = 0;
                            tmp = Convert.ToInt32(Console.ReadLine());
                            list.DeleteElement(tmp);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Write an element: ");
                            int tmp = 0;
                            tmp = Convert.ToInt32(Console.ReadLine());
                            if (list.SearchElement(tmp))
                            {
                                Console.WriteLine("List contains this element");
                            }
                            else
                            {
                                Console.WriteLine("List doesn't contain this element");
                            }
                            break;
                        }
                }
            }
        }
    }
}