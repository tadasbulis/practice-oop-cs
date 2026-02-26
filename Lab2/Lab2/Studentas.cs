using System;
namespace Lab2;

public class Studentas
{
    public string Vardas { get; }
    public string Pastas { get; }
    public int Id { get; }
    public double Vid { get; }

    public Studentas(string vardas, string pastas, int id, double vidurkis)
    {
        Vardas = vardas;
        Pastas = pastas;
        Id = id;
        Vid = vidurkis;
    }
}

