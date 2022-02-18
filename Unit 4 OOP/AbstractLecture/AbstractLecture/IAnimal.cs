using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractLecture
{
    internal interface IAnimal
    {
        void Move();
        void Eat();
        void Speak();
        int GetHunger();
    }
}
