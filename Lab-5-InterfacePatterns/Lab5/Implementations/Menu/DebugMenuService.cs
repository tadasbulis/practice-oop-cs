
using Lab5.Interfaces;
using Lab5.Services;
using Lab5.Models;

namespace Lab5.Implementations.Menu;

public class DebugMenuService : IMenuService
{
    private readonly StudentService _service;
    private readonly Queue<string> _inputs = new();

    public DebugMenuService(StudentService service)
    {
        _service = service;
    }

    public void Run()
    {
        Console.WriteLine("[DEBUG] Running automated menu simulation...");

        var group = new Group();
        var student = new Student(1, "Debug Student", "debug@test.com");
        student.AddGrade(7);
        student.AddGrade(8);
        student.AddGrade(9);

        group.AddStudent(student);

        _service.PrintGroup(group);

        double avg = _service.CalculateAverage(student);
        Console.WriteLine($"[DEBUG] Average: {avg}");

        bool isValid = _service.ValidateStudent(student);
        Console.WriteLine($"[DEBUG] Validation result: {isValid}");
    }
}
