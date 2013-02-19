using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_3
{
    class Program
    {
        static void CountSort(Int32 [] array)
        {
            const Int32 mas = 20;
            const Int32 range = 10;
            Int32 [] tmpArray = new Int32[range];

            for (int i = 0; i < range; ++i)
            {
                tmpArray[i] = 0;
            }

            for (int i = 0; i < mas; ++i)
            {
                tmpArray[array[i]]++;
            }

            Int32 tmp = 0;
            Int32 tmp1 = -1;
            while (tmp != 10)
            {
                if (tmpArray[tmp] != 0)
                {
                    tmp1++;
                    array[tmp1] = tmp;
                    tmpArray[tmp]--;
                }
                else
                {
                    tmp++;
                }
            }
        }

        static void Main(string[] args)
        {
            const Int32 mas = 20;
            const Int32 range = 10;
            Int32[] array = new Int32 [mas];

            for (int i = 0; i < mas; ++i)
            {
                array[i] = 0;
            }

            Random rand = new Random();

            Console.WriteLine("Unsorted array:");
            for (int i = 0; i < mas; ++i)
            {
                array[i] = rand.Next(range);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            CountSort(array);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < mas; ++i)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
