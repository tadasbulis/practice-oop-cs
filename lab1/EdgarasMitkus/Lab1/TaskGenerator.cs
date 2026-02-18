namespace Lab1;

// Primary constructor – pašalina IDE0290 patarimą
public class TaskGenerator(string vardasPavarde, string grupe, string data)
{
    // Sugeneruoja random užduotį ir atspausdina informacija
    public void GeneruotiIrRodyti(string[] args)
    {
        // Tikriname, ar paleista su --challenge
        bool allowChallenge = args.Contains("--challenge");

        // Nustatome maksimalų užduoties numerį: 4 arba 5
        int max = allowChallenge ? 5 : 4;

        // Sukuriame Random objektą
        Random rnd = new();

        // Sugeneruojame užduoties numerį
        int task = rnd.Next(1, max + 1);

        // Jei iškrito 5 – generuojame fallback
        int fallback = 0;
        if (task == 5)
        {
            fallback = rnd.Next(1, 5);
        }

        // Tavo originalus spausdinimo blokas – NIEKO NEKEIČIU, tik pakeičiu kintamuosius
        Console.WriteLine("## Lab 1");
        Console.WriteLine("");
        Console.WriteLine($"**Vardas Pavardė:** {vardasPavarde}");
        Console.WriteLine($"**Grupė:** {grupe}");
        Console.WriteLine($"**Paskaitos data:** {data}");
        Console.WriteLine($"**Random užduotis:** {task}");

        if (fallback > 0)
        {
            Console.WriteLine($"**Fallback (jei #5 per sunki):** {fallback}");
        }

        Console.WriteLine("");
        Console.WriteLine("### Paleidimas");
        Console.WriteLine("dotnet run -- --challenge");
        Console.WriteLine("");
        Console.WriteLine("### Kas įgyvendinta");
        Console.WriteLine("**Užduotis #3: Konsolinis meniu**");
        Console.WriteLine("- Sukurtos `Student` ir `Group` klasės pagal OOP principus");
        Console.WriteLine("- Pilnas konsolinis meniu (1 - Pridėti, 2 - Rodyti, 0 - Išeiti)");
        Console.WriteLine("- Dinaminis studentų sąrašas (`List<Student>`)");
        Console.WriteLine("");
        Console.WriteLine("**Užduotis #5: Validacija + Refactoring + OOP**");
        Console.WriteLine("- **Live validacija** įvedant naują studentą:");
        Console.WriteLine(" - ID (tik skaičius)");
        Console.WriteLine(" - Vardas (tik raidės, negali būti tuščias)");
        Console.WriteLine(" - El. paštas (turi turėti `@` ir `.`)");
        Console.WriteLine(" - Vidurkis (nuo 0 iki 10)");
        Console.WriteLine("- **Pilnas refactoring** pagal OOP principus:");
        Console.WriteLine(" - `private` laukai + `readonly` (tikras užkapsuliavimas)");
        Console.WriteLine(" - Konstruktoriai vietoj viešų properties");
        Console.WriteLine(" - Metodai `GetInfo()` ir `GetVidurkis()` Student klasėje");
        Console.WriteLine(" - Grupės bendro vidurkio skaičiavimas (`private` metodas Group klasėje)");
        Console.WriteLine(" - Group klasė nieko nežino apie Student vidų (tik per viešus metodus)");
        Console.WriteLine("- `TaskGenerator` klasė atsitiktinei užduočiai generuoti");
        Console.WriteLine("");
        Console.WriteLine("### Struktūra");
        Console.WriteLine("- `Program.cs` – pagrindinis programos ciklas ir meniu (koordinavimas)");
        Console.WriteLine("- `Student.cs` – studento klasė (privatūs laukai, konstruktorius, `GetInfo()`, `GetVidurkis()`)");
        Console.WriteLine("- `Group.cs` – grupės klasė (privatūs laukai, konstruktorius, validacija, vidurkio skaičiavimas)");
        Console.WriteLine("- `TaskGenerator.cs` – atsitiktinės užduoties generavimas");
        Console.WriteLine("");
    }
}