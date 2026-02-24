using Lab2.Models;
using Lab2.Services;

// Sukuriame bibliotekos objektą
Library biblioteka = new("Kauno biblioteka");

// Sukuriame service objektą – įrankių dėžė veiksmams atlikti
// new() be parametrų nes LibraryService pats duomenų nesaugo
LibraryService service = new();

// Pridedame kelias knygas iš karto kad būtų ką testuoti paleidus programą
// Nenaudojame Console – tiesiog programiškai sukuriame ir pridedame
// new Book(...) – sukuria knygos objektą tiesiai kaip parametrą
service.PridetiKnyga(biblioteka, new Book("Hobbit", "Tolkien", 1937));
service.PridetiKnyga(biblioteka, new Book("1984", "Orwell", 1949));
service.PridetiKnyga(biblioteka, new Book("Dune", "Herbert", 1965));

Console.WriteLine($"Sveiki! Biblioteka: {biblioteka.Pavadinimas}\n");

while (true)
{
    Console.WriteLine("\nMeniu:");
    Console.WriteLine("1 - Pridėti knygą");
    Console.WriteLine("2 - Rodyti visas knygas");
    Console.WriteLine("3 - Pasiskolinti knygą");
    Console.WriteLine("4 - Grąžinti knygą");
    Console.WriteLine("0 - Išeiti");

    // ?? "" – jei ReadLine grąžina null, naudojame tuščią string
    Console.Write("\nPasirinkimas: ");
    string pasirinkimas = Console.ReadLine() ?? "";

    // Jei vartotojas pasirinko 1 – pridėti knygą
    if (pasirinkimas == "1")
    {
        // Klausiame duomenų – Console logika tik čia, ne Service ar Model
        Console.Write("Pavadinimas: ");
        string pavadinimas = Console.ReadLine() ?? "";

        Console.Write("Autorius: ");
        string autorius = Console.ReadLine() ?? "";

        // Metų validacija – kartojame kol įves teisingą skaičių
        int metai;
        while (true)
        {
            Console.Write("Metai: ");
            // int.TryParse – bando paversti tekstą į skaičių
            // Jei pavyksta IR metai > 0 – išeiname iš ciklo
            if (int.TryParse(Console.ReadLine(), out metai) && metai > 0) break;
            Console.WriteLine("KLAIDA: Metai turi būti skaičius!");
        }

        // Sukuriame knygos objektą ir perduodame Service
        // Service prideda knygą į biblioteką – ne Program
        service.PridetiKnyga(biblioteka, new Book(pavadinimas, autorius, metai));
        Console.WriteLine("Knyga pridėta!");
    }
    else if (pasirinkimas == "2")
    {
        // Bibliotekos pavadinimas paimamas iš objekto property
        Console.WriteLine($"\nKnygos ({biblioteka.Pavadinimas}):");

        // Jei sąrašas tuščias – pranešame
        if (biblioteka.Knygos.Count == 0)
        {
            Console.WriteLine("Nėra knygų!");
        }
        else
        {
            // Rodome visas knygas
            // foreach – einame per kiekvieną knygą sąraše
            // k – tai kiekviena knyga po vieną
            foreach (Book k in biblioteka.Knygos)
            {
                // GetInfo() – knyga pati grąžina savo informaciją
                // Program tik spausdina – nežino kaip suformatuoti
                Console.WriteLine(k.GetInfo());
            }

            // Service skaičiuoja – ne Program, ne Library
            Console.WriteLine($"Laisvų knygų: {service.LaisvosSkaičius(biblioteka)}");
        }
    }
    else if (pasirinkimas == "3")
    {
        // Klausiame kokią knygą nori pasiskolinti
        Console.Write("Knygos pavadinimas: ");
        string pavadinimas = Console.ReadLine() ?? "";

        // Service ieško knygos ir pakeičia statusą
        // Grąžina true jei pavyko, false jei nepavyko
        if (service.Skolintis(biblioteka, pavadinimas))
            Console.WriteLine("Knyga pasiskolinta!");
        else
            Console.WriteLine("KLAIDA: Knyga nerasta arba jau pasiskolinta!");
    }
    else if (pasirinkimas == "4")
    {
        // Klausiame kokią knygą nori grąžinti
        Console.Write("Knygos pavadinimas: ");
        string pavadinimas = Console.ReadLine() ?? "";

        // Service ieško knygos ir grąžina ją
        // Grąžina true jei pavyko, false jei nepavyko
        if (service.Grazinti(biblioteka, pavadinimas))
            Console.WriteLine("Knyga grąžinta!");
        else
            Console.WriteLine("KLAIDA: Knyga nerasta arba nėra pasiskolinta!");
    }
    else if (pasirinkimas == "0")
    {
        // Vartotojas pasirinko išeiti – išeiname iš while ciklo
        Console.WriteLine("\nViso gero!\n");
        break;
    }
    else
    {
        // Vartotojas įvedė kažką kita – pranešame ir grįžtame į meniu
        Console.WriteLine("Neteisingas pasirinkimas!");
    }
}