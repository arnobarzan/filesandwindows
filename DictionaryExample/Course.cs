using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    public class Course
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public int Hours { get; set; }

        public Course(string name, string teacher, int hours)
        {
            Name = name;
            Teacher = teacher;
            Hours = hours;
        }
    }

}
