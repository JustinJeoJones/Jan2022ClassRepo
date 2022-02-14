using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLecture
{
    internal class Song
    {
        public string Name;
        public int BPM;
        public double Length;
        public int Rating;
        public string Artist;

        

        public void Listen()
        {
            Console.WriteLine($"You listen to {Name} for {Length} minutes");
        }

        public bool Enjoy()
        {
            return Rating >= 5;
        }
    }
}
