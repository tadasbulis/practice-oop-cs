# Lab 5 – Interface Patterns

## Architecture Overview


Program (Composition Root)
└── StudentService
    ├── IStudentRepository
    │   ├── MemoryStudentRepository   
    │   └── FileStudentRepository     
    │
    ├── IStudentPrinter
    │   ├── ConsoleStudentPrinter     
    │   ├── FileStudentPrinter        
    │   └── JsonStudentPrinter        
    │
    ├── IAverageStrategy
    │   ├── SimpleAverageStrategy     
    │   ├── WeightedAverageStrategy   
    │   └── MedianAverageStrategy     
    │
    └── IStudentValidator
        └── StudentValidatorAdapter   




 Patterns Implemented

 Strategy Pattern – `IStudentPrinter`

Location: `Implementations/Printer/`

Classes:
 Class / Behaviour 

 `ConsoleStudentPrinter` / Prints group to the console 
 `FileStudentPrinter` / Writes one student per line to `students.txt` 
 `JsonStudentPrinter` / Serialises the group to `students.json` 

Why the interface is useful:  
`StudentService.PrintGroup()` calls `_printer.Print(group)` through the `IStudentPrinter` contract. Swapping the printer in `Program.cs`  requires **no changes** to `StudentService`. Adding a new output format  is just a new class that implements the interface.



 Strategy Pattern – `IAverageStrategy`

Location: `Implementations/Strategy/`

Classes:
 Class / Behaviour 

 `SimpleAverageStrategy` / Arithmetic mean of all grades 
 `WeightedAverageStrategy` / Later grades carry more weight (weight = index + 1) 
 `MedianAverageStrategy` / Statistical median; resistant to outliers 

**Why the interface is useful:**  
`StudentService.CalculateAverage()` calls `_strategy.Calculate(student)` without knowing the algorithm. Switching from simple to weighted grading is a one-line change in `Program.cs`.



 Repository Pattern – `IStudentRepository`

Location: `Implementations/Repository/`

Classes:
Class / Data source 

 `MemoryStudentRepository` / Hard-coded in-memory demo student 
 `FileStudentRepository` / Reads from a CSV file (`id,name,email` per line) 

Why the interface is useful:  
`StudentService.FindStudent()` calls `_repository.Find(query)` and has **no knowledge** of where students are stored. The storage backend (memory, file, database, API) can be swapped entirely by changing one line in `Program.cs`.



 Adapter Pattern – `StudentValidatorAdapter`

Location: `Implementations/Adapter/`

Classes:
 Class / Role 

 `LegacyStudentValidation`/ Old system; incompatible signature `CheckStudent(name, email)` 
`StudentValidatorAdapter` / Wraps legacy class; exposes `IStudentValidator.Validate(Student)` 

Why the interface is useful:  
`StudentService` expects `IStudentValidator` with `Validate(Student student)`. The legacy system only understands raw strings. The adapter bridges the gap so the legacy logic can be reused without modifying either `StudentService` or `LegacyStudentValidation`.


Runtime Switching (Step 8)

All switching happens **only in `Program.cs`** – `StudentService` is never modified:

csharp
//printer
IStudentPrinter printer = new JsonStudentPrinter();   // or ConsoleStudentPrinter / FileStudentPrinter

//average algorithm
IAverageStrategy strategy = new WeightedAverageStrategy();  // or Simple / Median

//data source
IStudentRepository repository = new FileStudentRepository("students_data.csv");  


