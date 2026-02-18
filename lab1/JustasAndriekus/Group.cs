using System;
using System.Collections.Generic;

namespace OOP_c_2_lab1
{
    public class Group
    {
        public string Pavadinimas { get; set; }
        public List<Student> Studentas { get; set; }

        public Group(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
            Studentas = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Studentas.Add(student);
            Console.WriteLine($"Studentas {student.Vardas} pridėtas į grupę {Pavadinimas}");
        }

        public void PrintAll()
        {
            Console.WriteLine($"\nGrupė: {Pavadinimas}");
            Console.WriteLine("Studentų sąrašas:");
            Console.WriteLine("****************************");
            foreach (var student in Studentas)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine($"Išviso studentų: {Studentas.Count}\n");
        }
    }
}