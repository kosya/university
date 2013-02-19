using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_2
{
    class Program
    {
        static Int32 Fibonacci(Int32 value)
        {
            if (value == 1 || value == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(value - 1) + Fibonacci(value - 2);
            }
        }
        static void Main(string[] args)
        {
            Int32 value = 0;
            Console.Write("Write a number of Fibonacci number: ");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: {0}", Fibonacci(value));
        }
    }
}
