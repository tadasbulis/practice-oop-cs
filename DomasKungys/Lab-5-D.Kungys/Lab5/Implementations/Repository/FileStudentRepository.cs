using Lab5.Interfaces;
using Lab5.Models;

namespace Lab5.Implementations.Repository;

/// <summary>
/// Reads students from a CSV file (id,name,email per line).
/// StudentService never knows where the data comes from – Repository Pattern.
/// </summary>
public class FileStudentRepository : IStudentRepository
{
    private readonly string _filePath;

    public FileStudentRepository(string filePath = "students_data.csv")
    {
        _filePath = filePath;
    }

    public Student? Find(string query)
    {
        if (!File.Exists(_filePath))
        {
            Console.WriteLine($"[FileStudentRepository] File '{_filePath}' not found.");
            return null;
        }

        foreach (var line in File.ReadAllLines(_filePath))
        {
            var parts = line.Split(',');
            if (parts.Length < 3) continue;

            string name  = parts[1].Trim();
            string email = parts[2].Trim();

            if (name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                email.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                if (int.TryParse(parts[0].Trim(), out int id))
                    return new Student(id, name, email);
            }
        }

        return null;
    }
}
