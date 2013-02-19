using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_4
{
    class Program
    {
        const int n = 7;
        const int m = 8;

        static void ArraySort(int[,] array)
        {
            for (int i = 1; i < m - 1; ++i)
            {
                for (int j = 0; j < m - i; ++j)
                {
                    if (array[j, 0] > array[j + 1, 0])
                    {
                        int tmp = array[j, 1];
                        array[j, 1] = array[j + 1, 1];
                        array[j + 1, 1] = tmp;
                        tmp = array[j, 0];
                        array[j, 0] = array[j + 1, 0];
                        array[j + 1, 0] = tmp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix = new int[n, m];
            Random rand = new Random();

            Console.WriteLine("Unsorted matrix:");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    matrix[i, j] = 10 + rand.Next(69);
                    Console.Write("{0} ", matrix[i, j]);
                }
                    Console.WriteLine();
            }
            Console.WriteLine();

            int [,] tmpArray = new int[m, 2];
            for (int i = 0; i < m; ++i)
            {
                tmpArray[i, 0] = matrix[0, i];
                tmpArray[i, 1] = i;
            }

            ArraySort(tmpArray);
            int[,] resultMatrix = new int[n, m];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    resultMatrix[i, j] = 0;
                }
            }
            for (int j = 0; j < m; ++j)
            {
                for (int i = 0; i < n; ++i)
                {
                    resultMatrix[i, j] = matrix[i, tmpArray[j, 1]];
                }
            }

            Console.WriteLine("Sorted Matrix:");
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("{0} ", resultMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
