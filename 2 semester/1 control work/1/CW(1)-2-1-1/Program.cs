using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1__2_1_1
{
    class Program
    {
        static public int GetPriority(int value)
        {
            return value % 10;
        }

        static void Main(string[] args)
        {
            const int range = 69;
            const int amount = 20;
            Queue queue = new Queue();
           /* Random rand = new Random();

            for (int i = 0; i < amount; ++i)
            {
                int value = rand.Next(range);
                queue.Enqueue(value, GetPriority(value));
            }*/

            int command = -1;
            while (command != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Write 0 to exit");
                Console.WriteLine("Write 1 to add an element to the queue");
                Console.WriteLine("Write 2 to delete element");
                Console.Write("Command number: ");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        {
                            Console.Write("Write an element: ");
                            int tmp = 0;
                            tmp = Convert.ToInt32(Console.ReadLine());
                            queue.Enqueue(tmp, GetPriority(tmp));
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Element {0} was deleted", queue.Dequeue());
                            break;
                        }
                }
            }


        }
    }
}
