using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_4
{
    public class DivideZeroException : ApplicationException
    {
        public DivideZeroException()
        {
        }

        public DivideZeroException(string message)
            : base(message)
        {
        }
    }
}
