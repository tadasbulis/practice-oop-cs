using System;
using System.Text.RegularExpressions;

namespace uzduotis3
{
    internal class uzduotis3
    {
        static void Main(string[] args)
        {
            // meniu ir callina group is groups.cs
            Group group = new Group();
            ShowMenu(group);
        }

        // meniu metodas
        static void ShowMenu(Group group)
        {
            int choice;
            // do while, kad meniu printintu tol kol sustabdys ivedus 0
            do
            {
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Show");
                Console.WriteLine("0 - Exit");
                Console.Write("Pasirinkimas: ");
                // convertina string i inta
                choice = Convert.ToInt32(Console.ReadLine());
                // switchina tarp metodu (pasirinkimu)
                switch (choice)
                {
                    case 1:
                        AddStudent(group); // pridet studenta
                        break;
                    case 2:
                        group.PrintAll(); // printint visus
                        break;
                }

            } while (choice != 0); // veikia kol nelygu 0, jei gaunamas 0 programa sustabdoma
        }
        // prideda studenta
        static void AddStudent(Group group) 
        {
            Console.Write("Įveskite vardą: ");
            string name = Console.ReadLine();

            Console.Write("Įveskite amžių: ");
            int age = Convert.ToInt32(Console.ReadLine());

            StudentasClass student = new StudentasClass(name, age);
            group.AddStudent(student);

            Console.WriteLine("Studentas pridėtas.");
        }
    }
}