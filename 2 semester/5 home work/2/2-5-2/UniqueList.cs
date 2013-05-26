using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2
{
    public class UniqueList : List
    {
        public UniqueList()
        {
        }

        /// <summary>
        /// Method, which adds a new element in the list
        /// </summary>
        /// <param name="value">value of an element</param>
        public override void AddElement(int value)
        {
            if (SearchElement(value))
            {
                throw new RepeatedElementException("This element exists in the list");
            }
            else
            {
                base.AddElement(value);
            }
        }
    }
}
