using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_3
{
    class HashTable
    {
        public int tableSize;
        public List[] hashData;
        
        public HashTable(int size)
        {
            hashData = new List[size];
            tableSize = size;
            for (int i = 0; i < size; ++i)
            {
                hashData[i] = new List();
            }
        }

        public int Hash(int value)
        {
            int result = value % tableSize;
            return result;
        }

        public void AddElement(int value)
        {
            hashData[Hash(value)].Push(value);
        }

        public void DeleteElement(int value)
        {
            hashData[Hash(value)].DeleteElement(value);
        }

        public bool Search(int value)
        {
            if (hashData[Hash(value)].SearchElement(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintTable()
        {
            for (int i = 0; i < tableSize; ++i)
            {
                Console.Write("{0}-> ", i);
                hashData[Hash(i)].PrintList();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
