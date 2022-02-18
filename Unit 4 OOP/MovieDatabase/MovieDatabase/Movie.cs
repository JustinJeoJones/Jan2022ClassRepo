using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }

        public Movie(string _title, string _category, int _runTime)
        {
            Title = _title;
            Category = _category;
            RunTime = _runTime;
        }
    }
}
