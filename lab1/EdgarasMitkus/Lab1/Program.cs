using Lab1;

// Atsitiktinės užduoties generavimas
new TaskGenerator("Edgaras Mitkus", "PS-5", "2026-02-14").GeneruotiIrRodyti(args);

Group grupe = new("PS-5");

Console.WriteLine("\n\nUŽDUOTIS #3 ir #5: Studentų valdymas + validacija");

// Meniu ciklas
while (true)
{
    Console.WriteLine("\nMeniu:");
    Console.WriteLine("1 - Pridėti studentą");
    Console.WriteLine("2 - Rodyti visus studentus");
    Console.WriteLine("0 - Išeiti");
    Console.Write("\nPasirinkimas: ");

    string pasirinkimas = Console.ReadLine() ?? "";

    if (pasirinkimas == "1")
    {
        grupe.PridetiNaujaStudenta();
    }
    else if (pasirinkimas == "2")
    {
        grupe.RodytiVisus();
    }
    else if (pasirinkimas == "0")
    {
        Console.WriteLine("\nPrograma baigta.\n");
        break;
    }
    else
    {
        Console.WriteLine("Neteisingas pasirinkimas!");
    }
}