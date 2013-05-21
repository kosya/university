using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_4
{
    public class StackArray : IStack
    {
        private List<float> array = new List<float>();
       
        public StackArray()
        {
        }

        public void Push(float value)
        {
            array.Add(value);
        }

        public float Pop()
        {
            if (array.Count() == 0)
            {
                throw new EmptyStackException("Empty Stack"); 
            }
            else
            {
                float tmp = array[array.Count() - 1];
                array.RemoveAt(array.Count() - 1);
                return tmp;
            }
        }

        public int AmountOfElements()
        {
            return array.Count();
        }
    }
}
