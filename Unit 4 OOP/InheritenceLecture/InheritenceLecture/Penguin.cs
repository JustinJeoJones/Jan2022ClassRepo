using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceLecture
{
    internal class Penguin : Animal
    {
        public bool CanFly { get; set; }
        public bool IsClumsy { get; set; }  
        public bool IsParent { get; set; }
        public Penguin(string _name, double _height, double _weight, int _age, string _habitat, bool _isParent) : base(_name, _height, _weight, _age, _habitat)
        {
            CanFly = false;
            IsClumsy = true;
            IsParent = _isParent;
        }

        //overrides
        public override void Eat()
        {
            Console.WriteLine($"{Name} eats a fish.");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} falls down a hill");
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} screams loudly");
        }

        public override string ToString()
        {
            return base.ToString() + $" Can it fly: {CanFly} Is Clumsy: {IsClumsy} Is parent: {IsParent}";
        }
    }
}
