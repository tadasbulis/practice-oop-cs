
using Lab5.Interfaces;
using Lab5.Services;
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
        // Composition Root – only place where concrete classes are created

        IStudentRepository repository = new MemoryStudentRepository();
        IStudentPrinter printer = new ConsoleStudentPrinter();
        IAverageStrategy strategy = new SimpleAverageStrategy();
        IStudentValidator validator = new StudentValidatorAdapter();

        // Alternative runtime switching examples (uncomment to test):
        // IStudentRepository repository = new FileStudentRepository();
        // IStudentRepository repository = new ApiStudentRepository();

        // IStudentPrinter printer = new FileStudentPrinter();
        // IStudentPrinter printer = new JsonStudentPrinter();

        // IAverageStrategy strategy = new WeightedAverageStrategy();
        // IAverageStrategy strategy = new MedianAverageStrategy();

        // IMenuService menu = new DebugMenuService(service);
        // IMenuService menu = new WebMenuSimulationService(service);

        StudentService service = new StudentService(repository, printer, strategy, validator);

        IMenuService menu = new ConsoleMenuService(service);
        menu.Run();
    }
}
