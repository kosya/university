﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_2
{
    public class HashFunction1 : IHashFunction
    {
        public int Type { get; set; }
        
        public HashFunction1(int type)
        {
            this.Type = type;
        }

        public int GetIndex(int value)
        {
            return value % this.Type;
        }
    }
}