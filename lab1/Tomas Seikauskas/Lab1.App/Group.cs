using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab1
{
    public class Group
    {
        private List<Studentas> students = new List<Studentas>();

        public void SGroup()
        {
            // Pridėsim testinius studentus
            students.Add(new Studentas { Vardas = "Tomas", Pastas = "tomas@gmail.com", Id = 1, Vid = 8.5 });
            students.Add(new Studentas { Vardas = "Ieva", Pastas = "ieva@gmail.com", Id = 2, Vid = 9.1 });
            students.Add(new Studentas { Vardas = "Jurgis", Pastas = "jurgis@gmail.com", Id = 3, Vid = 5.1 });
        }

        public Studentas? FindById(int id)
        {
            return students.Find(s => s.Id == id);
        }

        public Studentas? FindByEmail(string email)
        {
            return students.Find(s => s.Pastas.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
}

