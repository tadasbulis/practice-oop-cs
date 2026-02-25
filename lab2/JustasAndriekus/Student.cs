using System;

namespace OOP_c_2_lab2
{
    public class Student
    {
        public int Id { get; }
        public string Vardas { get; }
        public string ElPastas { get; }
        public double Vidurkis { get; }

        public Student(int id, string vardas, string elPastas, double vidurkis)
        {
            Id = id;
            Vardas = vardas;
            ElPastas = elPastas;
            Vidurkis = vidurkis;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Vardas: {Vardas}, El. Paštas: {ElPastas}, Vidurkis: {Vidurkis:F1}";
        }
    }
}