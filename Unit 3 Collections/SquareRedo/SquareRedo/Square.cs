using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareExercise
{
    internal class Square
    {
     
        public int SideLength { get; set; }

        public string Color { get; set; }

        // Constructor
        public Square(int length, string color)
        {
            SideLength = length;
            Color = color;
        }

        // Methods

        public int CalculateArea()
        {
            return SideLength * SideLength;
        }

        public int CalculatePerimeter()
        {
            return 4 * SideLength;
        }
    }
}

