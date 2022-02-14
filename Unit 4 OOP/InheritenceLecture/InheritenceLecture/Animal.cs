using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceLecture
{
    internal class Animal
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Habitat { get; set; }

        //constructor
        public Animal(string _name, double _height, double _weight, int _age, string _habitat)
        {
            Name = _name;
            Height = _height;
            Weight = _weight;
            Age = _age;
            Habitat = _habitat;
        }

        //methods
        public virtual void Move()
        {
            Console.WriteLine($"{Name} has moved");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} has eaten");
        }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} has spoken");
        }

        //override
        public override string ToString()
        {
            return $"Name: {Name} Height: {Height} Weight: {Weight} Age: {Age} Habitat: {Habitat}";
        }
    }
}
