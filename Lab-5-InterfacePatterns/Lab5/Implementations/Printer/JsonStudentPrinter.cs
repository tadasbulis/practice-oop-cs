
using Lab5.Interfaces;
using Lab5.Models;
using System.Text.Json;

namespace Lab5.Implementations.Printer;

public class JsonStudentPrinter : IStudentPrinter
{
    public void Print(Group group)
    {
        var students = group.Students.Select(s => new
        {
            s.Id,
            s.Name,
            s.Email,
            Grades = s.Grades.ToArray()
        }).ToList();

        string json = JsonSerializer.Serialize(students, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        string filePath = "output.json";
        File.WriteAllText(filePath, json);

        Console.WriteLine($"JSON output saved to {filePath}");
        Console.WriteLine(json);
    }
}
