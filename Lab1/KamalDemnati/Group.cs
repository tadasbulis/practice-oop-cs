using System;
using System.Collections.Generic;

namespace Lab1
{
    internal class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Group(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void AddStudent(Student s)
        {
            Students.Add(s);
        }

        public void PrintAll()
        {
            Console.WriteLine($"\n--- Students in {Name} ---");

            if (Students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            foreach (Student s in Students)
                s.PrintInfo();
        }

        public Student FindById(int id)
        {
            foreach (Student s in Students)
                if (s.Id == id)
                    return s;

            return null;
        }

        public Student FindByEmail(string email)
        {
            foreach (Student s in Students)
                if (s.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                    return s;

            return null;
        }
    }
}
