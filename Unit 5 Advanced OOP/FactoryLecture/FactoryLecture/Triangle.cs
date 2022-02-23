using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLecture
{
    internal class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is a triangle");
        }
    }
}
