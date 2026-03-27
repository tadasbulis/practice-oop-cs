
using Lab5.Interfaces;
using Lab5.Services;
using Lab5.Models;
using Lab5.Implementations.Repository;
using Lab5.Implementations.Printer;
using Lab5.Implementations.Strategy;
using Lab5.Implementations.Menu;
using Lab5.Implementations.Adapter;

namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
        // ── Composition Root ────────────────────────────────────────────────
        // Only place where concrete classes are created.
        // StudentService never changes – only the injected implementations do.

        // Step 6 – Repository Pattern: swap MemoryStudentRepository ↔ FileStudentRepository
        IStudentRepository repository = new MemoryStudentRepository();
        // IStudentRepository repository = new FileStudentRepository("students_data.csv");

        // Step 4 – Strategy Pattern (Printer): swap at runtime
        IStudentPrinter printer = new ConsoleStudentPrinter();
        // IStudentPrinter printer = new FileStudentPrinter("students.txt");
        // IStudentPrinter printer = new JsonStudentPrinter("students.json");

        // Step 5 – Strategy Pattern (Average): swap at runtime
        IAverageStrategy strategy = new SimpleAverageStrategy();
        // IAverageStrategy strategy = new WeightedAverageStrategy();
        // IAverageStrategy strategy = new MedianAverageStrategy();

        // Step 7 – Adapter Pattern: LegacyStudentValidation wrapped behind IStudentValidator
        IStudentValidator validator = new StudentValidatorAdapter();

        // StudentService depends only on interfaces – Clean Architecture
        StudentService service = new StudentService(repository, printer, strategy, validator);

        // ── Demo: show all strategies working without changing StudentService ──
        var group = new Group();

        var alice = new Student(1, "Alice", "alice@test.com");
        alice.AddGrade(6);
        alice.AddGrade(8);
        alice.AddGrade(10);
        group.AddStudent(alice);

        var bob = new Student(2, "Bob", "bob@test.com");
        bob.AddGrade(7);
        bob.AddGrade(7);
        bob.AddGrade(9);
        group.AddStudent(bob);

        Console.WriteLine("=== Console Printer ===");
        service.PrintGroup(group);

        Console.WriteLine($"\nSimple  average (Alice): {service.CalculateAverage(alice):F2}");

        // Runtime switch – only Program.cs changes, StudentService stays the same
        StudentService serviceWeighted = new StudentService(
            repository,
            new FileStudentPrinter(),
            new WeightedAverageStrategy(),
            validator);

        Console.WriteLine($"Weighted average (Alice): {serviceWeighted.CalculateAverage(alice):F2}");

        StudentService serviceMedian = new StudentService(
            repository,
            new JsonStudentPrinter(),
            new MedianAverageStrategy(),
            validator);

        Console.WriteLine($"Median  average (Alice): {serviceMedian.CalculateAverage(alice):F2}");

        Console.WriteLine($"\nValidate Alice: {service.ValidateStudent(alice)}");
        Console.WriteLine($"Find student:   {service.FindStudent("Alice")?.Name ?? "not found"}");

        Console.WriteLine("\n=== File Printer output ===");
        serviceWeighted.PrintGroup(group);   // writes students.txt

        Console.WriteLine("\n=== JSON Printer output ===");
        serviceMedian.PrintGroup(group);     // writes students.json

        Console.WriteLine("\nDone. Check students.txt and students.json.");
    }
}
