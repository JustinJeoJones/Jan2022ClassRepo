using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceLecture
{
    internal class Dog : Animal
    {
        public double FurLength { get; set; }
        public bool GoodDog { get; set; }
        public Dog(string _name, double _height, double _weight, int _age, string _habitat, double _furLength) : base(_name, _height, _weight, _age, _habitat)
        {
            FurLength = _furLength;
            GoodDog = true;
        }

        //override
        public override void Eat()
        {
            //base.Eat();
            Console.WriteLine($"{Name} has eaten chicken");
        }

        public override void Move()
        {
            //base.Move();
            Console.WriteLine($"{Name} has ran towards a squirrel");
        }

        public override void Speak()
        {
            //base.Speak();
            Console.WriteLine($"{Name} has borfed");
        }

        public override string ToString()
        {
            return base.ToString() + $" Fur Length: {FurLength} Good Dog: {GoodDog}";
        }
    }
}
