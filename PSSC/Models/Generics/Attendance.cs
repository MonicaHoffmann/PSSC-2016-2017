﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    //prezenta la laborator

    //value object
    public class Attendance
    {
        private int _count;
        public int Count { get; internal set; }

        public Attendance(int count)
        {
            _count = count;
        }
    }
}