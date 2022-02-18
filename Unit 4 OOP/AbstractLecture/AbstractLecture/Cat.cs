using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLecture
{
    internal class Cat : IAnimal
    {
        public string Name { get; set; }
        public int Hunger { get; set; }

        public Cat(string _name, int _hunger)
        {
            Name = _name;
            Hunger = _hunger;
        }
        public void Eat()
        {
            Console.WriteLine("Cat eats some kibble");
        }

        public int GetHunger()
        {
            return Hunger;
        }

        public void Move()
        {
            Console.WriteLine("The cat gets zoomies at 3am");
        }

        public void Speak()
        {
            Console.WriteLine("MEOOOOWWWWW");
        }
    }
}
