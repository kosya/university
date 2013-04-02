using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_1__2_1_1
{
    public class EmptyQueueException : ApplicationException
    {
        public EmptyQueueException()
        {
        }

        public EmptyQueueException(string message)
            : base(message)
        {
        }
    }
}
