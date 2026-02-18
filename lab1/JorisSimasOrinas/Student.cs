public class Student
{
    public int Id { get; set; }
    public string Vardas { get; set; }
    public string ElPastas { get; set; }
    public double Vidurkis { get; set; }

    public Student(int id, string vardas, string elPastas, double vidurkis)
    {
        Id = id;
        Vardas = vardas;
        ElPastas = elPastas;
        Vidurkis = vidurkis;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"ID: {Id}, Vardas: {Vardas}, El. paštas: {ElPastas}, Vidurkis: {Vidurkis:F2}");
    }
}
