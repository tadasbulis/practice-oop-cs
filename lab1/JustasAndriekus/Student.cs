using System;

namespace OOP_c_2_lab1
{
    public class Student
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string ElPastas { get; set; }
        public string Vidurkis { get; set; }

        public Student(int id, string vardas, string elPastas, string vidurkis)
        {
            Id = id;
            Vardas = vardas;
            ElPastas = elPastas;
            Vidurkis = vidurkis;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Vardas: {Vardas}, El. Paštas: {ElPastas}, Vidurkis: {Vidurkis}";
        }
    }
}