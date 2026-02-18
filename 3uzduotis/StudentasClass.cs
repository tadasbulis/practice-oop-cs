using System;

namespace uzduotis3
{
    internal class StudentasClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public StudentasClass(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Vardas: {Name}, Amžius: {Age}");
        }
    }
}