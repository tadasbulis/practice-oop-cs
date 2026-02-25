using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.App
{
    class Group
    {
        private string Pavadinimas { get; set; } //grupes pavadinimas
        private List<Student> Students { get; set; } //studentu sarasas

        public Group(string Pavadinimas,  List<Student> Students)
        {
            this.Pavadinimas = Pavadinimas;
            this.Students = Students;
        }

        public Group(string Pavadinimas)
        {
            this.Pavadinimas=Pavadinimas;
            this.Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void PrintAll()
        {
            foreach (Student student in this.Students)
            {
                Console.WriteLine("ID: {0}\nVardas: {1}\nEl. paštas: {2}",
                    student.getId(), student.getName(), student.getEmail());
                Console.WriteLine("---------------");
            }
        }
    }
}
