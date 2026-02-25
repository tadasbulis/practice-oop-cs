using System;
using System.Collections.Generic;
using System.Linq;

class Studentas
{
    // Studentas turi vardą ir pažymius
    public string Vardas { get; set; }
    public List<int> Pazymiai { get; set; }

    public Studentas(string vardas, List<int> pazymiai)
    {
        Vardas = vardas;
        Pazymiai = pazymiai;
    }

    // Apskaičiuoja vidurkį
    public double GetAverage()
    {
        if (Pazymiai.Count == 0)
            return 0;

        return Pazymiai.Average();
    }

    // Spausdina informacija
    public void PrintInfo()
    {
        Console.WriteLine($"Studentas: {Vardas}");
        Console.WriteLine($"Pažymiai: {string.Join(", ", Pazymiai)}");
        Console.WriteLine($"Vidurkis: {GetAverage():F2}");
    }
    
}

class Programa
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        bool allowChallenge = args.Contains("--challenge");
        int max = allowChallenge ? 5 : 4;

        int task = rnd.Next(1, max + 1);

        if (task == 5)
        {
            int fallback = rnd.Next(1, 5);
            Console.WriteLine($"Iškrito #5 (challenge). Fallback: #{fallback}");
        }
        else
        {
            Console.WriteLine($"Tavo užduotis: #{task}");
        }
        
        if (task == 2)
        {
            Console.WriteLine("Vykdoma užduotis #2");
            Studentas s1 = new Studentas("Lukas", new List<int> { 8, 9, 10 });
            Studentas s2 = new Studentas("Aivaras", new List<int> { 6, 7, 8 });
            Studentas s3 = new Studentas("Paulius", new List<int> { 9, 10, 10 });

            s1.PrintInfo();
            s2.PrintInfo();
            s3.PrintInfo();
        }
        else
        {
            Console.WriteLine("Ši užduotis nepadaryta");
        }
    }
}


