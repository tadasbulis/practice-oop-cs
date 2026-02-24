using System.Collections.Generic;
using System.Linq;

namespace Lab2;

public class Group
{
    private List<Studentas> studentai = new List<Studentas>
    {
        new Studentas("Jonas", "jonas@gmail.com", 1, 8.5),
        new Studentas("Petras", "petras@gmail.com", 2, 7.2),
        new Studentas("Ona", "ona@gmail.com", 3, 9.1)
    };

    public Studentas? FindById(int id)
    {
        return studentai.FirstOrDefault(s => s.Id == id);
    }

    public Studentas? FindByEmail(string email)
    {
        return studentai.FirstOrDefault(s => s.Pastas == email);
    }

    public bool AddStudent(Studentas student)
    {
        
        if (studentai.Any(s => s.Id == student.Id))
        {
            return false; 
        }

        studentai.Add(student);
        return true; 
    }
}