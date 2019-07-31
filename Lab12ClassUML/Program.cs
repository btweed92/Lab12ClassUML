using System;
using System.Collections.Generic;

namespace Lab12ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Staff("Grand Circus", 1000000, "TA Steve", "Detroit, Mi"  ),
                new Staff("Grand Circus", 5000000, "Inst. Anna", "Detroit, Mi"  ),
                new Student("C#", 1, 15000, "Brandyn", "St Clair Shores, Mi"),
                new Student("C#", 2, 20000, "Josh", "Eastpointe, Mi"),
                new Student("C#", 3, 25000, "Joe", "Toledo, Mi")
            };
            foreach(var human in people)
            {
                Console.WriteLine(human);
            }
        }
    }
}
