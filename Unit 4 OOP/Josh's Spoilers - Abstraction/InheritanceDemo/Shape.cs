using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    enum TypeOfShape
    {
        Circle,
        Rectangle,
        Square,
        Triangle
    }
    internal abstract class Shape
    {
        public int Radius { get; set; }
        
        public int Side { get; set; }

        public TypeOfShape Name { get; set; }

        public int NumberOfSides { get; set; }

        // Calculate Area, and Calculate Perimeter
        public Shape(int _radius)
        {
            this.Radius = _radius;
        }

        public Shape(int _side, int _numberOfSides)
        {
            this.Side = _side;
            this.NumberOfSides = _numberOfSides;
        }



        // Will be overwriten by children
        public virtual double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public virtual double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        
    }
}
