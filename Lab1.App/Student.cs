using System;
using System.Collections.Generic;

namespace Lab1.App
{
    public class Student
    {
        public string Vardas { get; set; }
        public List<int> Grades { get; set; }

        public Student(string vardas)
        {
            Vardas = vardas;
            Grades = new List<int>();
        }

        public double GetAverage()
        {
            if (Grades.Count == 0)
                return 0;

            int suma = 0;
            foreach (int pazymys in Grades)
            {
                suma += pazymys;
            }
            return (double)suma / Grades.Count;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Studentas: " + Vardas);
            Console.WriteLine("Vidurkis: " + GetAverage().ToString("0.00"));
            Console.WriteLine("------------------------");
        }
    }
}
