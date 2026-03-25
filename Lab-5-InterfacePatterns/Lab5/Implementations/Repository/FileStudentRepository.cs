
using Lab5.Interfaces;
using Lab5.Models;

namespace Lab5.Implementations.Repository;

public class FileStudentRepository : IStudentRepository
{
    private readonly string _filePath = "students.txt";

    public FileStudentRepository()
    {
        if (!File.Exists(_filePath))
        {
            File.Create(_filePath).Dispose();
        }
    }

    public Student? Find(string query)
    {
        if (!File.Exists(_filePath))
            return null;

        string[] lines = File.ReadAllLines(_filePath);

        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line))
                continue;

            string[] parts = line.Split(',');
            if (parts.Length >= 3 && (parts[0].Contains(query) || parts[1].Contains(query) || parts[2].Contains(query)))
            {
                if (int.TryParse(parts[0], out int id))
                {
                    var student = new Student(id, parts[1], parts[2]);
                    if (parts.Length > 3)
                    {
                        for (int i = 3; i < parts.Length; i++)
                        {
                            if (int.TryParse(parts[i], out int grade))
                            {
                                student.AddGrade(grade);
                            }
                        }
                    }
                    return student;
                }
            }
        }

        return null;
    }
}
