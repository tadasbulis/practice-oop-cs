using Lab1.App;
using System.Security.Cryptography;

/*
Random rnd = new Random();
bool allowChallenge = args.Contains("--challenge");
int max = allowChallenge ? 5 : 4;
int task = rnd.Next(1, max + 1);

if(allowChallenge)
{
    Console.WriteLine("**Vardas Pavardė:** Armandas Kontrauskas");
    Console.WriteLine("**Grupė:** PS-5");
    Console.WriteLine("**Paskaitos data:** 2026-02-11");
    Console.WriteLine("**Random užduotis:** {0}", task);
}*/

bool exit = false;
int step = 3;

Group group = new Group("PS-5");
Tools tools = new Tools();

Console.WriteLine("-Programos pradžia.-\nPasirinkite variantą (skaičių):");
while (!exit)
{
    Console.WriteLine("1. Add\n2. Show\n3. Exit");
    step = Convert.ToInt32(Console.ReadLine());
    switch(step)
    {
        case 1:
            group.AddStudent(tools.CreateStudent());
            break;
        case 2:
            Console.WriteLine("---------------");
            group.PrintAll();
            break;
        case 3:
            exit = true;
            Console.WriteLine("Programa uždaroma...");
            break;
        default:
            Console.WriteLine("Bro?");
            break;
    }
}

