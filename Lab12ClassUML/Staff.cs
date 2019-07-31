using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }

        public Staff()
        {
            School = "What school?";
            Pay = 0.00;
        }
        public Staff(string school, double pay, string name, string address)
            :base(name, address)
        {
            School = school;
            Pay = pay;
        }
        public override string ToString()
        {
            return $"{Name} {Address} {School} {Pay}";
        }
    }
}
