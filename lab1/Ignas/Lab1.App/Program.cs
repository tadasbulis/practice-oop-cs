using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1.App
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }

        public Student(string name, List<int> grades)
        {
            Name = name;
            Grades = grades;
        }

        public double GetAverage()
        {
            if (Grades == null || Grades.Count == 0) 
                return 0;
            
            return Grades.Average();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Vardas: {Name,-15} | Pažymiai: {string.Join(", ", Grades),-12} | Vidurkis: {GetAverage():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Jonas Jonaitis", new List<int> { 10, 8, 9, 7 }),
                new Student("Aistė Petraitė", new List<int> { 9, 10, 10, 9 }),
                new Student("Lukas Lukauskas", new List<int> { 4, 6, 5, 7 })
            };

            Console.WriteLine("Laboratorinis darbas Nr. 1 - Užduotis 2");
            Console.WriteLine(new string('-', 60));

            foreach (var student in students)
            {
                student.PrintInfo();
            }

            Console.WriteLine(new string('-', 60));
        }
    }
}