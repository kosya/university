﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_2
{
    public class EmptyListException : ApplicationException
    {
        public EmptyListException()
        {
        }

        public EmptyListException(string message)
            : base(message)
        {
        }
    }
}