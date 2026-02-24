namespace Lab2.Services;

using Lab2.Models;
// SERVICE klasė – visi veiksmai su biblioteka ir knygomis
// SERVICE niekada nerašo į Console – tik atlieka veiksmus
// SERVICE gauna Model objektus kaip parametrus ir dirba su jais

public class LibraryService
{
    // METODAS: prideda naują knygą į biblioteką
    // Gauna Library ir Book objektus – pats jų nekuria
    public void PridetiKnyga(Library biblioteka, Book knyga)
    {
        biblioteka.Knygos.Add(knyga);
    }

    // METODAS: pasiskolina knygą pagal pavadinimą
    // Grąžina bool – true jei pavyko, false jei nepavyko
    public bool Skolintis(Library biblioteka, string pavadinimas)
    {
        // Ieškome knygos pagal pavadinimą (ignoruojame didžiąsias/mažąsias raides)
        Book? knyga = biblioteka.Knygos
            .FirstOrDefault(k => k.Pavadinimas.Equals(pavadinimas, StringComparison.OrdinalIgnoreCase));

        // Jei knyga nerasta arba jau pasiskolinta – nepavyko
        if (knyga == null || knyga.Pasiskolinta) return false;

        // Pasiskoliname – knyga pati žino kaip keisti savo statusą
        knyga.Skolintis();
        return true;
    }

    // METODAS: grąžina knygą pagal pavadinimą
    public bool Grazinti(Library biblioteka, string pavadinimas)
    {
        Book? knyga = biblioteka.Knygos
            .FirstOrDefault(k => k.Pavadinimas.Equals(pavadinimas, StringComparison.OrdinalIgnoreCase));

        // Jei knyga nerasta arba nėra pasiskolinta – nepavyko
        if (knyga == null || !knyga.Pasiskolinta) return false;

        knyga.Grazinti();
        return true;
    }

    // METODAS: skaičiuoja kiek knygų yra laisvos
    public int LaisvosSkaičius(Library biblioteka)
    {
        return biblioteka.Knygos.Count(k => !k.Pasiskolinta);
    }
}