using System;
using System.Collections.Generic;

namespace lab1.App;


public class Student 
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Student(string firstName, string lastName) 
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class Group 
{
    public string Name { get; set; }
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student) => students.Add(student);

    public void PrintAll() 
    {
        Console.WriteLine($"\n--- Group: {Name} ---");
        if (students.Count == 0) Console.WriteLine("No students added yet.");
        foreach (var s in students) 
        {
            Console.WriteLine($"- {s.FirstName} {s.LastName}");
        }
    }
}

class Program 
{
    static Group myGroup = new Group { Name = "OOP Lab Group" };

    static void Main() 
    {
        
        RunMenu();
    }

    static void RunMenu() 
    {
        string choice = "";
        while (choice != "0") 
        {
            Console.WriteLine("\nMenu: 1-Add, 2-Show, 0-Exit");
            Console.Write("Select: ");
            choice = Console.ReadLine();

            switch (choice) 
            {
                case "1": AddStudentFlow(); break;
                case "2": myGroup.PrintAll(); break;
            }
        }
    }

    static void AddStudentFlow() 
    {
        Console.Write("Enter First Name: ");
        string fn = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        string ln = Console.ReadLine();
        
        myGroup.AddStudent(new Student(fn, ln));
        Console.WriteLine("Student added successfully!");
    }
}
