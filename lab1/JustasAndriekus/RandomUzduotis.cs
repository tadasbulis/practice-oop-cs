using System;
using OOP_c_2_lab1;

//Random užduoties gavimas
public class RandomUzduotis
{
    public static void randomuzd(string[] args)
    {
        StudentProfile student = new StudentProfile();
        string result = student.ToReadmeBlock(1, args);
        Console.WriteLine(result);

        Random rnd = new Random();
        bool allowChallenge = args.Contains("--challenge");
        int max = allowChallenge ? 5 : 4;
        int task = rnd.Next(1, max + 1);

        if (task == 5)
        {
            int fallback = rnd.Next(1, 5); // 1..4
                                           // rodyti ir #5, ir fallback
            Console.WriteLine("Užduotis: " + task);
            Console.WriteLine("Fallback užduotis: " + fallback);
        }
        else Console.WriteLine("Random užduotis: " + task);
    }
}


public class StudentProfile
{
    public string Vardas { get; set; } = "Justas";
    public string Pavarde { get; set; } = "Andriekus";
    public string Grupe { get; set; } = "PS-5";
    public DateOnly PaskaitosData { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public string ToReadmeBlock(int taskNo, string[] args)
    {
        return $"Vardas Pavardė: {Vardas} {Pavarde}\n" +
        $"Grupė: {Grupe}\n" +
        $"Paskaitos data: {PaskaitosData}";
    }
}