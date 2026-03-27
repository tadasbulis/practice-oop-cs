using Lab5.Interfaces;
using Lab5.Models;

namespace Lab5.Implementations.Printer;

public class FileStudentPrinter : IStudentPrinter
{
    private readonly string _filePath;

    public FileStudentPrinter(string filePath = "students.txt")
    {
        _filePath = filePath;
    }

    public void Print(Group group)
    {
        var lines = group.Students
            .Select(s => $"{s.Id} | {s.Name} | {s.Email}");

        File.WriteAllLines(_filePath, lines);
        Console.WriteLine($"[FileStudentPrinter] Group written to '{_filePath}'.");
    }
}
