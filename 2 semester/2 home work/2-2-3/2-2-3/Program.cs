using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_3
{
    class Program
    {
        const int n = 7;

        static void OutputElements(int[,] matrix, int n)
        {
            Console.WriteLine();
            Console.WriteLine("Elements of matrix:");
            int range = 1;
            while (range <= n)
            {
                if (range == 1)
                {
                    Console.Write("{0} ", matrix[n / 2, n / 2]);
                    range += 2;
                }
                else
                {
                    int arg1 = n / 2 - range / 2;
                    int arg2 = n / 2 - 1 - range / 2;
                    for (int i = 1; i <= range; ++i)
                    {
                        arg2++;
                        Console.Write("{0} ", matrix[arg1, arg2]);
                    }
                    for (int i = 1; i <= range - 1 ; ++i)
                    {
                        arg1++;
                        Console.Write("{0} ", matrix[arg1, arg2]);
                    }
                    for (int i = 1; i <= range - 1; ++i)
                    {
                        arg2--;
                        Console.Write("{0} ", matrix[arg1, arg2]);
                    }
                    for (int i = 1; i <= range - 2; ++i)
                    {
                        arg1--;
                        Console.Write("{0} ", matrix[arg1, arg2]);
                    }
                    range += 2;
                }
            }
        }

        static void Main(string[] args)
        {
            int [,] matrix = new int [n, n];
            Random rand = new Random();
            Console.WriteLine("Matrix:");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    matrix[i, j] = 10 + rand.Next(69);
                    Console.Write("{0}  ", matrix[i, j]);
                }
                Console.WriteLine();
            }
            OutputElements(matrix, n);
            Console.WriteLine();
        }
    }
}
