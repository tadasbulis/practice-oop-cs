using lab2.Models;
using System.Linq;

namespace lab2.Services

{
public class StudentService
{
    private List<Student>_students = new List<Student>();
    
    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void AddStudent(string name, int age, double average)
    {
        Student student = new Student(name, age, average);
        _students.Add(student);
    }

    public void PrintStudents()
    {
        foreach (var student in _students)
        {
            Console.WriteLine($"Vardas: {student.Name}, Amžius: {student.Age}, Vidurkis: {student.Average}");
        }
    }

    public double GetAverageGrade()
    {
        if (_students.Count == 0)
            return 0;

        return _students.Average(s => s.Average);
    }

    public Student? GetBestStudent()
    {
        if (_students.Count == 0)
            return null;

        return _students.OrderByDescending(s => s.Average).FirstOrDefault();
    }
}
}