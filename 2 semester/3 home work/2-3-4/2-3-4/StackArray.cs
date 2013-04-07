using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_4
{
    public class StackArray : IStack
    {
        private List<int> array = new List<int>();
       
        public StackArray()
        {
        }

        public void Push(int value)
        {
            array.Add(value);
        }

        public int Pop()
        {
            int tmp = array[array.Count() - 1];
            array.RemoveAt(array.Count() - 1);
            return tmp;
        }

        public int AmountOfElements()
        {
            return array.Count();
        }
    }
}
