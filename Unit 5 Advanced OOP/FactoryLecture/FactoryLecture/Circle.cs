﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLecture
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is a circle");
        }
    }
}
