namespace Lab2.Models;
// MODEL klasė – tik saugo duomenis apie knygą
// MODEL niekada nerašo į Console ir neturi jokios logikos


// PRIMARY CONSTRUCTOR – tai modernus C# būdas aprašyti konstruktorių
// Konstruktorius = specialus metodas kuris paleidžiamas kai kuriamas objektas
// Pvz: new Book("Hobitas", "Tolkien", 1937)
// Parametrai pavadinimas, autorius, metai automatiškai tampa klasės dalimi
public class Book(string pavadinimas, string autorius, int metai)
{
    // ENKAPSULIACIJOS PAVYZDYS:
    // { get; } = tik skaityti iš išorės, negalima keisti
    // = pavadinimas – reikšmė paimama iš konstruktoriaus parametro
    // Niekas negali parašyti: knyga.Pavadinimas = "kažkas" – gaus klaidą
    public string Pavadinimas { get; } = pavadinimas;
    public string Autorius { get; } = autorius;
    public int Metai { get; } = metai;

    // ENKAPSULIACIJOS PAVYZDYS #2:
    // public – matoma iš išorės (galima skaityti)
    // private set – keisti gali TIK ši klasė, per savo metodus
    // = false – pradinė reikšmė: knyga nėra pasiskolinta
    public bool Pasiskolinta { get; private set; } = false;

    // METODAS – veiksmas kurį knyga gali atlikti su savimi
    // => tai "expression body" – modernus trumpas būdas rašyti metodą
    // Kai iškviečiamas Skolintis() – Pasiskolinta tampa true
    public void Skolintis() => Pasiskolinta = true;

    // Kai iškviečiamas Grazinti() – Pasiskolinta grįžta į false
    public void Grazinti() => Pasiskolinta = false;

    // METODAS grąžinantis string – nenaudoja Console
    // Tai MODEL principas – grąžink duomenis, nespausdink pats
    public string GetInfo() =>
        $"{Pavadinimas} – {Autorius} ({Metai}) [{(Pasiskolinta ? "Pasiskolinta" : "Yra")}]";
}