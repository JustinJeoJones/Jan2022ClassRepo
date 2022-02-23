using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Lecture
{
    internal class Singleton
    {
        //private instance to limit instances to 1
        private static Singleton instance = null;

        //private constructor so there is no public one
        private Singleton()
        {

        }
        public static Singleton getInstance()
        {
            if(instance == null)
            {
                Console.WriteLine("Creating new instance");
                instance = new Singleton();
            }

            return instance;
        }
    }
}
