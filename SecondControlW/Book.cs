﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondControlW
{
    class Book
    {
        public string Name;
        public int Year;
        public string Author;

        public override string ToString()
        {
            return $"{ Name } {Year} {Author}";
        }
    }
}
