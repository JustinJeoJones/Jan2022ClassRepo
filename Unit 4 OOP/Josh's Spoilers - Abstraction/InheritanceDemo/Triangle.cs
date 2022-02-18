using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Triangle : Shape
    {
        public int Height { get; set; }

        public Triangle(int _side, int _numberOfSides) : base(_side, _numberOfSides)
        {
            Height = _numberOfSides;
        }

        public override double CalculateArea()
        {
            return Side * Height * .5;
        }

        public override double CalculatePerimeter()
        {
            return Side * 3;
        }
    }
}
