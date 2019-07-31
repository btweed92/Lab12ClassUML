using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12ClassUML
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student()
        {
            Program = "What program are you in?";
            Year = 0;
            Fee = 0.00;
        }

        public Student(string program, int year, double fee, string name, string address)
            :base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
        public override string ToString()
        {
            return $"{Name} {Address} {Program} {Year} {Fee}";
        }
    }
}
