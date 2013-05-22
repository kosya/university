using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_2
{
    public class HashTable
    {
        private int tableSize;
        private List[] hashData;
        private IHashFunction hashfunction;

        public HashTable(int type)
        {
            hashfunction = new HashFunction1(type);
            hashData = new List[type];
            this.tableSize = type;
            for (int i = 0; i < type; ++i)
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
        /// Method, which adds an element to hash table
        /// </summary>
        /// <param name="value">value of the element</param>
        public void AddElement(int value)
        {
            hashData[hashfunction.GetIndex(value)].AddElement(value);
        }

        /// <summary>
        /// Method, which deletes element from the table
        /// </summary>
        /// <param name="value">value of the element</param>
        public void DeleteElement(int value)
        {
            hashData[hashfunction.GetIndex(value)].DeleteElement(value);
        }

        /// <summary>
        /// Method, which search for required element
        /// </summary>
        /// <param name="value">value of the element</param>
        /// <returns>if element is in the hash table then method returns true else returns false </returns>
        public bool Search(int value)
        {
            return hashData[hashfunction.GetIndex(value)].SearchElement(value);
        }

        /// <summary>
        /// Method, which print elements of the table
        /// </summary>
        public void PrintTable()
        {
            for (int i = 0; i < tableSize; ++i)
            {
                Console.Write("{0}-> ", i);
                hashData[i].PrintList();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
