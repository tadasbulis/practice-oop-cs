
using Lab5.Interfaces;
using Lab5.Models;

namespace Lab5.Implementations.Printer;

public class FileStudentPrinter : IStudentPrinter
{
    public void Print(Group group)
    {
        string filePath = "output.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var student in group.Students)
            {
                writer.WriteLine($"{student.Id} {student.Name} {student.Email}");
            }
        }

        Console.WriteLine($"Output saved to {filePath}");
    }
}
