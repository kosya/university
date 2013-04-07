using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_4
{
    public interface IStack
    {
        /// <summary>
        /// Adds a new element in the stack
        /// </summary>
        /// <param name="value">value of the element</param>
        void Push(int value);

        /// <summary>
        /// Returns value of the deleted element of the stack
        /// </summary>
        /// <returns>value of the deleted element</returns>
        int Pop();
        
        /// <summary>
        /// Returns amount of elements of the stack
        /// </summary>
        /// <returns>amount of elements</returns>
        int AmountOfElements();
    }
}
