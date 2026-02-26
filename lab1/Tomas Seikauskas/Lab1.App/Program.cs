using System;
using System.Linq;
namespace Lab1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();

            bool allowChallenge = args.Contains("--challenge");
            int max = allowChallenge ? 5 : 4;

            int task = rnd.Next(1, max + 1);

            StudentProfile profile = new StudentProfile();

            Console.WriteLine($"Vardas Pavarde: {profile.Vardas} {profile.Pavarde}");
            Console.WriteLine($"Grupe: {profile.Grupe}");
            Console.WriteLine($"Paskaitos data: {profile.PaskaitosData}");
            Console.WriteLine($"Random Uzduotis: {task}");

            
            Console.WriteLine("--------------------------------------------------------------------------------------");
            RandomLab(task);

            Uzduotis();

        }

        public static void Uzduotis()
        {
          Group group = new Group();

            Console.WriteLine("Paieska pagal id");
            int id = Convert.ToInt32(Console.ReadLine());

            Studentas student = group.FindById(id);

            if (student != null)
            {
                Console.WriteLine($"Rastas studentas: {student.Vardas}, {student.Pastas}, Vidurkis: {student.Vid}");
            }
            else
            {
                Console.WriteLine("Studentas nerastas!");
            }

            Console.WriteLine("Paieska pagal el. pastą");
            string email = Console.ReadLine()!;
            Studentas studentByEmail = group.FindByEmail(email);

            if (studentByEmail != null)
            {
                Console.WriteLine($"Rastas studentas: {studentByEmail.Vardas}, {studentByEmail.Pastas}, Vidurkis: {studentByEmail.Vid}");
            }
            else
            {
                Console.WriteLine("Studentas nerastas!");
            }
        }

        public static void RandomLab(int task)
        {
            if (task == 5)
            {
                Random rnd = new Random();
                int fallback = rnd.Next(1, 5);
                Console.WriteLine($"Fallback task: {fallback}");
            }
        }

    }

}

