﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Apple : ISellable
    {
        public decimal Price { get; set; } = 0.50M;
    }
}
