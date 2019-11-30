using System;
using System.Collections.Generic;
using System.Text;

namespace BenchmarkTest
{
    public class Person
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
    public class VSProfiler
    {
        private static List<Person> persons = new List<Person>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000000; i++)
            {
                AddNewNumber();
            }
        }
        private static void AddNewNumber()
        {
            persons.Add(new Person
            {
                Code = 1,
                Name = "firstname lastname"
            });
        }
    }
}
