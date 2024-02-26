using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Student : Person
    {
        public List<Course> Courses { get; set; }

        public Student(int id, string name) : base(id, name)
        {
            Courses = new List<Course>();
        }
    }
