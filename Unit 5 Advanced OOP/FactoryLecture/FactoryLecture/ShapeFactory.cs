using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLecture
{
    internal class ShapeFactory
    {
        public IShape getShape(string type)
        {
            IShape result = null;
            if(type == "square")
            {
                result = new Square();
            }
            else if(type == "circle")
            {
                result = new Circle();
            }
            else if(type == "triangle")
            {
                result = new Triangle();
            }


            return result;
        }
    }
}
