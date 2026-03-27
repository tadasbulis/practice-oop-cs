using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }

    public Student(string name, List<double> grades)
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
        Console.WriteLine($"Vardas: {Name}, Vidurkis: {GetAverage():F2}");
    }

    
}


