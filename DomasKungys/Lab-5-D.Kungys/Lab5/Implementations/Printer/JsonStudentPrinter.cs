using System.Text.Json;
using Lab5.Interfaces;
using Lab5.Models;

namespace Lab5.Implementations.Printer;

public class JsonStudentPrinter : IStudentPrinter
{
    private readonly string _filePath;

    public JsonStudentPrinter(string filePath = "students.json")
    {
        _filePath = filePath;
    }

    public void Print(Group group)
    {
        var data = group.Students.Select(s => new
        {
            s.Id,
            s.Name,
            s.Email,
            Grades = s.Grades.ToList()
        });

        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(_filePath, json);
        Console.WriteLine($"[JsonStudentPrinter] Group written to '{_filePath}'.");
    }
}
