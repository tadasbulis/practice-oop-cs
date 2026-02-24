namespace Lab2.Models;
// MODEL klasė – tik saugo duomenis apie biblioteką
// MODEL niekada nerašo į Console ir neturi jokios logikos


// PRIMARY CONSTRUCTOR – sukuria biblioteką su pavadinimu
// Pvz: new Library("Kauno biblioteka")
public class Library(string pavadinimas)
{
    // { get; } – tik skaityti iš išorės, negalima keisti
    // Niekas negali parašyti: biblioteka.Pavadinimas = "kažkas"
    public string Pavadinimas { get; } = pavadinimas;

    // List<Book> – dinaminis knygų sąrašas (kaip masyvas bet be ribų)
    // { get; } – sąrašo negalima pakeisti į kitą sąrašą iš išorės
    // Bet elementus (knygas) galima pridėti per LibraryService
    // [] – modernus .NET 10 būdas rašyti new List<Book>()
    public List<Book> Knygos { get; } = [];
}