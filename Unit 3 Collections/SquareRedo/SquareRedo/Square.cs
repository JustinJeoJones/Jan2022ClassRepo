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

