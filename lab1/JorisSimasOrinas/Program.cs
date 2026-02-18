using System;

class Program
{
    static void Main(string[] args)
    {
        Group grupe = new Group("Programavimas 1");

        // Sukuriame bent 3 studentus
        Student s1 = new Student(1, "Jonas Jonaitis", "jonas@gmail.com", 8.5);
        Student s2 = new Student(2, "Ona Onaite", "ona@gmail.com", 9.1);
        Student s3 = new Student(3, "Petras Petraitis", "petras@gmail.com", 7.8);

        // Pridedame studentus į grupę
        grupe.AddStudent(s1);
        grupe.AddStudent(s2);
        grupe.AddStudent(s3);

        // Atspausdiname informaciją
        grupe.PrintAll();

        Console.ReadLine();
    }
}
