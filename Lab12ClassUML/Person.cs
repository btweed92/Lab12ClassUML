using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    class Person
    {
        protected string Name { get; set; }
        protected string Address { get; set; }

        public Person()
        {
            Name = "Please enter a name";
            Address = "Please enter an address";
        }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"{Name} {Address}";
        }
    }
}
