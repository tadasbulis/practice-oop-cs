// See https://aka.ms/new-console-template for more information
using System;
using System;
using System.IO;
using Lab1.App;

class Program
{
    static void Main(string[] args)
    {
        Group group = new Group("PS-5");

        group.AddStudent(new Students(1, "Vaidas", "vaidas@gmail.com"));
        group.AddStudent(new Students(2, "Jonas", "jonas@gmail.com"));
        group.AddStudent(new Students(3, "Ona", "ona@gmail.com"));

        Console.WriteLine("Pasirinkite paiešką:");
        Console.WriteLine("1 - Pagal ID");
        Console.WriteLine("2 - Pagal el. paštą");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Write("Įveskite ID: ");
            int id = int.Parse(Console.ReadLine());

            var student = group.FindById(id);

            if (student != null)
                Console.WriteLine($"Rastas studentas: {student}");
            else
                Console.WriteLine("Studentas su tokiu ID nerastas.");
        }
        else if (choice == "2")
        {
            Console.Write("Įveskite el. paštą: ");
            string email = Console.ReadLine();

            var student = group.FindByEmail(email);

            if (student != null)
                Console.WriteLine($"Rastas studentas: {student}");
            else
                Console.WriteLine("Studentas su tokiu el. paštu nerastas.");
        }
        else
        {
            Console.WriteLine("Neteisingas pasirinkimas.");
        }


        Random rnd = new Random();
        bool allowChallenge = args.Contains("--challenge");
        int max = allowChallenge ? 5 : 4;
        int task = rnd.Next(1, max + 1);

        if (task == 5)
        {
            int fallback = rnd.Next(1, 5);

        }
        string path = @"C:\Users\vaidas.lau199\Lab1\Lab1.App\README.md";

        string content = $"""
            ## lab 1

            **Vardas Pavarde:** Vaidas Laurinaitis
            **Grupė:** PS-5
            **Paskaitos data:** 2026-02-10
            **Random užduotis:** {task}
            **Fallback (jei #5 per sunki):** 2

            ### Paleidimas
            dotnet run --project Lab1.App

            ### Ką įgyvendinta

            - Yra paieksa pagal ID ir email
            - Jeigu nera tokio zmogaus ismeta i konsole, kad nera tokio
            - Sekmingai atlikau uzduoti

            """;

        File.WriteAllText(path, content);


    }
}
