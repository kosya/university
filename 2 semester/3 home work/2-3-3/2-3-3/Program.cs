using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_3
{
    class Program
    {
        static void Main()
        {
            const int tableSize = 5;
            const int range = 69;
            const int amount = 20;
            Random rand = new Random();

            HashTable hashTable = new HashTable(tableSize);
            /*Console.WriteLine("Elements:");
            for (int i = 0; i < amount; ++i)
            {
                int tmp = rand.Next(range);
                hashTable.AddElement(tmp);
                Console.Write("{0} ", tmp);
            }
            Console.WriteLine();
            hashTable.PrintTable();*/

            int command = -1;

            while (command != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Write 0 to exit");
                Console.WriteLine("Write 1 to add an element");
                Console.WriteLine("Write 2 to delete an element");
                Console.WriteLine("Write 3 to search an element");
                Console.WriteLine("Write 4 to print table");
                Console.Write("Command: ");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        {
                            Console.WriteLine("Element value: ");
                            int value = 0;
                            value = Convert.ToInt32(Console.ReadLine());
                            hashTable.AddElement(value);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Element value: ");
                            int value = 0;
                            value = Convert.ToInt32(Console.ReadLine());
                            hashTable.DeleteElement(value);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Element value: ");
                            int value = 0;
                            value = Convert.ToInt32(Console.ReadLine());
                            if (hashTable.Search(value))
                            {
                                Console.WriteLine("Table contains this element");
                            }
                            else
                            {
                                Console.WriteLine("Table doesn't contain this element");
                            }
                            break;
                        }
                    case 4:
                        {
                            hashTable.PrintTable();
                            break;
                        }
                }
            }
        }
    }
}
