using System;
using System.Collections.Generic;

public class Group
{
    public string Pavadinimas { get; set; }
    public List<Student> Students { get; set; }

    public Group(string pavadinimas)
    {
        Pavadinimas = pavadinimas;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void PrintAll()
    {
        Console.WriteLine($"Grupė: {Pavadinimas}");
        foreach (var student in Students)
        {
            student.PrintInfo();
        }
    }
}
