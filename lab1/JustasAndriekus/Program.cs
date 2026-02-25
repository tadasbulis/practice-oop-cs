using System;
using OOP_c_2_lab1;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** UŽDUOTIS 1: Studentų grupė ***\n");

        //Sukuria grupę
        Group grupe = new Group("PS-5");

        //Studentai
        Student studentas1 = new Student(1, "Jonas Jonaitis", "jonas@example.com", "8.5");
        Student studentas2 = new Student(2, "Petras Petraitis", "petras@example.com", "9.0");
        Student studentas3 = new Student(3, "Jokūbas Jokubaitis", "jokubas@example.com", "7.8");

        //Prideda studentus į grupę
        grupe.AddStudent(studentas1);
        grupe.AddStudent(studentas2);
        grupe.AddStudent(studentas3);

        //Rodo visą informaciją
        grupe.PrintAll();

        Console.WriteLine("\n*** RANDOM UŽDUOTIS ***\n");

        //Random užduoties gavimas
        RandomUzduotis.randomuzd(args);
    }
}