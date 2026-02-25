using System;
using System.Collections.Generic;

namespace OOP_c_2_lab2
{
    public class Group
    {
        public string Pavadinimas { get; }
        public List<Student> Studentai { get; } = new();

        public Group(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }

        public void AddStudent(Student studentas)
        {
            Studentai.Add(studentas);
        }

        public string PrintAll()
        {
            var lines = new List<string>();
            lines.Add($"\nGrupė: {Pavadinimas}");
            lines.Add("Studentų sąrašas:");
            lines.Add("****************************");
            foreach (var studentas in Studentai)
                lines.Add(studentas.ToString());
            lines.Add($"Išviso studentų: {Studentai.Count}\n");
            return string.Join("\n", lines);
        }
    }
}