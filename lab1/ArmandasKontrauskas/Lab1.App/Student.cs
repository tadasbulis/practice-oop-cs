using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lab1.App
{
    class Student
    {
        private int id {get; set;} //studento id
        private string name { get; set; } //studento vardas
        private string email { get; set; } //studento el. pastas
        private double average { get; set; } // studento vidurkis
        private List<int> grades { get; set; } //studento pazymiai


        public Student(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.grades = new List<int>();
            this.average = 0;
        }

        public double getAverage()
        {
            return this.average; 
        }

        public string getEmail() { return this.email; }

        public int getId() { return this.id; }

        public string getName() { return this.name; }
        
    }
}
