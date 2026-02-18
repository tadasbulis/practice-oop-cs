namespace Lab1;

// Konstruktorius (primary)
public class Student(int id, string vardas, string elPastas, double vidurkis)
{
    // Viskas Private
    private readonly int id = id;
    private readonly string vardas = vardas;
    private readonly string elPastas = elPastas;
    private readonly double vidurkis = vidurkis;

    // Viešas metodas spausdinimui
    public string GetInfo()
    {
        return $"ID: {id}, Vardas: {vardas}, El.paštas: {elPastas}, Vidurkis: {vidurkis:F2}";
    }

    // Gauti vidurkį
    public double GetVidurkis() => vidurkis;
}