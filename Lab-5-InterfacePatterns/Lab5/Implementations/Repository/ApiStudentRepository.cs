
using Lab5.Interfaces;
using Lab5.Models;

namespace Lab5.Implementations.Repository;

public class ApiStudentRepository : IStudentRepository
{
    public Student? Find(string query)
    {
        Console.WriteLine("[API] Simulating HTTP request to external service...");
        Console.WriteLine($"[API] GET /api/students/search?q={query}");

        Task.Delay(500).Wait();

        Console.WriteLine("[API] Received response (200 OK)");

        return new Student(101, "API Student", "api@external.com");
    }
}
