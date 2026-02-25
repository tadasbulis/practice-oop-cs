using lab2.Models;
using lab2.Services;


class Program
{
    static void Main(string[] args)
    {
        var service = new StudentService();

        service.AddStudent("Jonas", 20, 8.5);
        service.AddStudent("Petras", 22, 9.0);
        service.AddStudent("Ona", 19, 7.5);

        Console.WriteLine("Studentų sąrašas:");
        service.PrintStudents();

        Console.WriteLine($"Vidutinis pažymių vidurkis: {service.GetAverageGrade():F2}");

        var bestStudent = service.GetBestStudent();
        if (bestStudent != null)
        {
            Console.WriteLine($"Geriausias studentas: {bestStudent.Name} su vidurkiu {bestStudent.Average}");
        }
    }
}
