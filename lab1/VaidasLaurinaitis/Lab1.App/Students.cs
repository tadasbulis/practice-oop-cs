using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.App
{
    internal class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public Students(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Vardas: {Name}, El. paštas: {Email}";
        }

    }
}
