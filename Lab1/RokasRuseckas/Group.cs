using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Group
{
    private List<Student> students = new List<Student>();

    public void Add (Student student)
    {
        students.Add(student);
    }

    public Student? FindById(int id)
    {
        foreach (Student s in students)
        {
            if (s.Id == id)
            {
                return s; // radom – grąžinam
            }
        }

        return null; // jei nieko neradom
    }


    public Student? FindByEmail(string email)
    {
        foreach (Student s in students)
        {
            if (s.Email.ToLower() == email.ToLower())
            {
                return s;
            }
        }

        return null;
    }
}
