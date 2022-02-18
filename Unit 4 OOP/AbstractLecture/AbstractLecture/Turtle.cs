using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLecture
{
    internal class Turtle : IAnimal
    {
        public string Name { get; set; }
        public int Hunger { get; set; }
        public Turtle(string _name, int _hunger)
        {
            Name = _name;
            Hunger = _hunger;
        }
        public void Eat()
        {
            Console.WriteLine("The turtle eats some leafs");
        }

        public int GetHunger()
        {
            return Hunger;
        }

        public void Move()
        {
            Console.WriteLine("The turtle runs a marthon in 98 weeks");
        }

        public void Speak()
        {
            Console.WriteLine("The turtle makes some kinda noise");
        }
    }
}
