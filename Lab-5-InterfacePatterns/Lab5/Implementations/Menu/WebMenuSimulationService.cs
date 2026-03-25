
using Lab5.Interfaces;
using Lab5.Services;
using Lab5.Models;

namespace Lab5.Implementations.Menu;

public class WebMenuSimulationService : IMenuService
{
    private readonly StudentService _service;

    public WebMenuSimulationService(StudentService service)
    {
        _service = service;
    }

    public void Run()
    {
        Console.WriteLine("[WEB SIMULATION] Simulating web endpoints...");

        Console.WriteLine("\nGET /api/students");
        var group = new Group();
        var student = new Student(1, "Web User", "webuser@domain.com");
        student.AddGrade(9);
        student.AddGrade(8);

        group.AddStudent(student);
        _service.PrintGroup(group);

        Console.WriteLine("\nGET /api/students/1/average");
        double avg = _service.CalculateAverage(student);
        Console.WriteLine($"Response: {{ \"student_id\": 1, \"average\": {avg} }}");

        Console.WriteLine("\nGET /api/students/1/validate");
        bool isValid = _service.ValidateStudent(student);
        Console.WriteLine($"Response: {{ \"valid\": {isValid.ToString().ToLower()} }}");
    }
}
