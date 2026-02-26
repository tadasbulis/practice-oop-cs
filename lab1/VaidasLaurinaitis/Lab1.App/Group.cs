using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.App
{
    internal class Group
    {

        public string Name { get; set; }
        private List<Students> Students { get; set; }

        public Group(string name)
        {
            Name = name;
            Students = new List<Students>();
        }

        public void AddStudent(Students student)
        {
            Students.Add(student);
        }

        public Students? FindById(int id)
        {
            return Students.FirstOrDefault(s => s.Id == id);
        }

        public Students? FindByEmail(string email)
        {
            return Students.FirstOrDefault(s =>
                s.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
    }
}
