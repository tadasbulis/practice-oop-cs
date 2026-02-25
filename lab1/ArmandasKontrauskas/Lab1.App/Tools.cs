using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.App
{
    class Tools
    {
        public Student CreateStudent()
        {
            Console.WriteLine("Studento id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Studento vardas:");
            string name = Console.ReadLine();
            Console.WriteLine("Studento email:");
            string email = Console.ReadLine();

            Student student = new Student(id, name, email);
            return student;
        }
    }
}
