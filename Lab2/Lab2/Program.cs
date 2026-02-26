using System;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lab2
{
    public class Program
    {
        private static Group group = new Group();
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
            Challange(task);

            int p = -1;
            while (p != 0)
            {
                Console.WriteLine("Pasirinkite:");
                Console.WriteLine("0. Iseiti");
                Console.WriteLine("1. Prideti studenta");
                Console.WriteLine("2. Studento Paieska pagal id");
                Console.WriteLine("3. Studento Paieska pagal el. pastą");

                p = Convert.ToInt32(Console.ReadLine());
                switch (p)
                {
                    case 0:
                        Console.WriteLine("Programos pabaiga...");
                        break;
                    case 1:
                        PridetiStudenta();
                        break;
                    case 2:
                        PaieskaPagalId();
                        break;
                    case 3:
                        PaieskaPagalEmail();
                        break;
                    default:
                        Console.WriteLine("Neteisingas pasirinkimas, bandykite dar kartą.");
                        break;
                }
            }
        }

        public static void Challange(int task)
        {
            if (task == 5)
            {
                Random rnd = new Random();
                int fallback = rnd.Next(1, 5);
                Console.WriteLine($"Fallback task: {fallback}");
            }
        }

        public static void PridetiStudenta()
        {
            Console.Write("Iveskite studento varda: ");
            string vardas = Console.ReadLine()!;

            Console.Write("Iveskite studento pasta: ");
            string pastas = Console.ReadLine()!;

            Console.Write("Iveskite studento id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Iveskite studento vidurki: ");
            double vid = Convert.ToDouble(Console.ReadLine());

            Studentas student = new Studentas(vardas, pastas, id, vid);

            bool prideta = group.AddStudent(student);
            if (prideta)
            {
                Console.WriteLine("Studentas sekmingai pridetas");
            }
            else
            {
                Console.WriteLine("Klaida: studentas su tokiu ID jau egzistuoja");
            }
        }

        public static void PaieskaPagalId()
        {
            Console.Write("Iveskite id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Studentas? student = group.FindById(id);

            if (student != null)
                Console.WriteLine($"Rastas: {student.Vardas}, {student.Pastas}, Vidurkis: {student.Vid}");
            else
                Console.WriteLine("Studentas nerastas");
        }

        public static void PaieskaPagalEmail()
        {
            Console.Write("Iveskite el. pasta: ");
            string email = Console.ReadLine()!;

            Studentas? student = group.FindByEmail(email);

            if (student != null)
                Console.WriteLine($"Rastas: {student.Vardas}, {student.Pastas}, Vidurkis: {student.Vid}");
            else
                Console.WriteLine("Studentas nerastas!");
        }

    }

}

