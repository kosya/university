using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_3
{
    public class HashTable
    {
        private int tableSize;
        private List[] hashData;
        
        public HashTable(int size)
        {
            hashData = new List[size];
            tableSize = size;
            for (int i = 0; i < size; ++i)
            {
                hashData[i] = new List();
            }
        }

        /// <summary>
        /// Method, which shows us if hash table is empty or not.
        /// </summary>
        /// <returns>if hash table is empty then returns true else returns false</returns>
        public bool IsEmpty()
        {
            for (int i = 0; i < tableSize; ++i)
            {
                if (!hashData[i].IsEmpty())
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Hash function
        /// </summary>
        /// <param name="value">value of the element</param>
        /// <returns>index</returns>
        public int Hash(int value)
        {
            int result = value % tableSize;
            return result;
        }

        /// <summary>
        /// Method, which adds an element to hash table
        /// </summary>
        /// <param name="value">value of the element</param>
        public void AddElement(int value)
        {
            hashData[Hash(value)].AddElement(value);
        }

        /// <summary>
        /// Method, which deletes element from the table
        /// </summary>
        /// <param name="value">value of the element</param>
        public void DeleteElement(int value)
        {
            hashData[Hash(value)].DeleteElement(value);
        }

        /// <summary>
        /// Method, which search for required element
        /// </summary>
        /// <param name="value">value of the element</param>
        /// <returns>if element is in the hash table then method returns true else returns false </returns>
        public bool Search(int value)
        {
            return hashData[Hash(value)].SearchElement(value);
        }

        /// <summary>
        /// Method, which print elements of the table
        /// </summary>
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
