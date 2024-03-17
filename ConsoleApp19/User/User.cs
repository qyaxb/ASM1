using ConsoleApp19;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp19
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
        
    }
}
