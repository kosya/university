﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2
{
    public class RepeatedElementException : ApplicationException
    {
        public RepeatedElementException(string message)
            : base(message)
        {
        }
    }
}
