﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Teacher : User
    {
        public string Department { get; set; }

        public Teacher(int id, string name, string department) : base(id, name)
        {
            Department = department;
        }
    }
}
