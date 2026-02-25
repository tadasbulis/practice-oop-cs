using System;
using OOP_c_2_lab2;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** UŽDUOTIS 1: Studentų grupė ***\n");

        Group grupe = new Group("PS-5");

        grupe.AddStudent(new Student(1, "Jonas Jonaitis", "jonas@example.com", 8.5));
        grupe.AddStudent(new Student(2, "Petras Petraitis", "petras@example.com", 9.0));
        grupe.AddStudent(new Student(3, "Jokūbas Jokubaitis", "jokubas@example.com", 7.8));

        Console.WriteLine(grupe.PrintAll());

        Console.WriteLine("\n*** RANDOM UŽDUOTIS ***\n");
        RandomUzduotis.randomuzd(args);
    }
}