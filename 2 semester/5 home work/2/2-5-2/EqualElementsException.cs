﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2
{
    public class EqualElementsException : ApplicationException
    {
        public EqualElementsException(string message)
            : base(message)
        {
        }
    }
}