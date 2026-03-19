using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<double> Grades { get; set; }

    public Student(string firstName, string lastName, List<double> grades)
    {
        FirstName = firstName;
        LastName = lastName;
        Grades = grades;
    }

    public double GetAverage()
    {
        return Grades.Average();
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{FirstName} {LastName} - Average: {GetAverage():0.00}");
    }
}
