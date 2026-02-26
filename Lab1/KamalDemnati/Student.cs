using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<double> Grades { get; set; }

        public Student(int id, string first, string last, string email, List<double> grades)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            Email = email;
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
            Console.WriteLine($"[{Id}] {FirstName} {LastName} | Email: {Email} | Avg: {GetAverage():0.00}");
        }
    }
}
