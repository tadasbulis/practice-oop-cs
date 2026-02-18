namespace Lab1;

// Konstruktorius (primary)
public class Group(string pavadinimas)
{
    private readonly string pavadinimas = pavadinimas;
    private readonly List<Student> studentai = [];

    // Metodas pridėti studentą
    public void PridetiStudenta(Student studentas)
    {
        studentai.Add(studentas);
    }

    // Metodas: parodyti visus studentus
    public void RodytiVisus()
    {
        Console.WriteLine($"\nStudentai grupėje: {pavadinimas}");

        if (studentai.Count == 0)
        {
            Console.WriteLine("Nėra studentų!");
            return;
        }

        foreach (Student s in studentai)
        {
            Console.WriteLine(s.GetInfo());
        }

        Console.WriteLine($"Grupės bendras vidurkis: {SkaiciuotiVidurki():F2}");
    }

    // Private metodas
    private double SkaiciuotiVidurki()
    {
        if (studentai.Count == 0) return 0;
        return studentai.Average(s => s.GetVidurkis());
    }

    // UŽDUOTIS #5
    // Metodas: pridėti naują studentą su validacija
    public void PridetiNaujaStudenta()
    {
        Console.WriteLine("\nNaujas studentas");

        // ID
        int id;
        while (true)
        {
            Console.Write("Įvesk ID: ");
            if (int.TryParse(Console.ReadLine(), out id)) break;
            Console.WriteLine("KLAIDA: ID turi būti skaičius!");
        }

        // Vardas
        string vardas;
        while (true)
        {
            Console.Write("Įvesk vardą: ");
            vardas = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(vardas) && !vardas.Any(char.IsDigit)) break;
            Console.WriteLine("KLAIDA: Vardas turi būti žodis be skaičių!");
        }

        // El. paštas
        string elpastas;
        while (true)
        {
            Console.Write("Įvesk el. paštą: ");
            elpastas = Console.ReadLine() ?? "";
            if (elpastas.Contains('@') && elpastas.Contains('.')) break;
            Console.WriteLine("KLAIDA: El. paštas turi turėti @ ir . !");
        }

        // Vidurkis
        double vidurkis;
        while (true)
        {
            Console.Write("Įvesk vidurkį: ");
            if (double.TryParse(Console.ReadLine(), out vidurkis) && vidurkis >= 0 && vidurkis <= 10) break;
            Console.WriteLine("KLAIDA: Vidurkis nuo 0 iki 10!");
        }

        // Sukuriame per konstruktorių (jau ne object initializer)
        Student naujas = new(id, vardas, elpastas, vidurkis);
        PridetiStudenta(naujas);   // naudojame savo metodą
        Console.WriteLine("\nStudentas pridėtas!");
    }
}
