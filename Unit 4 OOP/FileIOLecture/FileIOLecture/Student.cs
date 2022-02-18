using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOLecture
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public Student(string _name, int _age, int _grade)
        {
            Name = _name;
            Age = _age;
            Grade = _grade;
        }
    }
}


/* Justin/24/3
 * Josh/18/12
 * Carmen/18/11
 */

/*Justin
 *24
 *3
 * 
 * new student(value[0], value[1], value[2])
 * 
 * classroom.add(newstudent)
 */