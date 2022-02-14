using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLecture
{
    internal class Pen
    {
        //properties
        public string Color { get; set; }
        public string Brand { get; set; }
        public string InkType { get; set; }
        public decimal Price { get; set; }
        public float Length { get; set; }
        private int InkLevel;

        //Constructor
        public Pen(string _color, string _brand, string _inktype, decimal _price, float _length)
        {
            Color = _color;
            Brand = _brand;
            InkType = _inktype;
            Price = _price;
            Length = _length;

            //not a parameter, this is a starting value
            InkLevel = 5;
        }

        //Methods
        public void Draw()
        {
            if(InkLevel > 0)
            {
                Console.WriteLine($"The {Color} {Brand} pen draws a beautiful butterfly"); 
                InkLevel--;
            }
            else
            {
                Console.WriteLine("Out of ink");
            }
           
        }

        public string GetInfo()
        {
            return $"{Color} {Brand} {InkType} ${Price} {Length} inches";
        }

    }


}
