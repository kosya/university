using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_1
{
    class Program
    {
        static int Factorial(int value)
        {
            int result = 0;
            if (value == 0 || value == 1)
            {
                result = 1;
            }
            else
            {
                result = value * Factorial(value - 1); 
            }
            return result;
        }
        static void Main(string[] args)
        {
            int value = 0;
            Console.Write("Write a value: ");
            value = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial: {0}", Factorial(value));
        }
    }
}
