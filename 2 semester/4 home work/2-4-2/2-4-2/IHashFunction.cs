using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_2
{
    public interface IHashFunction
    {
        /// <summary>
        /// Method, which returns index of the element
        /// </summary>
        /// <param name="value">value of the element</param>
        /// <returns>index</returns>
        int GetIndex(int value);
    }
}
