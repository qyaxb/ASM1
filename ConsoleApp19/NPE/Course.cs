using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Teacher Teacher { get; set; }

        public Course(int id, string name, Teacher teacher)
        {
            Id = id;
            Name = name;
            Teacher = teacher;
        }
    }
}
