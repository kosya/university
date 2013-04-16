using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_2
{
    public class HashFunction
    {
        public int Type { get; set; }

        public HashFunction(int type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Method, which returns index of the element
        /// </summary>
        /// <param name="value">value of the element</param>
        /// <returns>index</returns>
        public int GetIndex(int value)
        {
            return value % Type;
        }
    }
}
