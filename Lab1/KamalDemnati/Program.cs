using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("Programming Group");

            RunMenu(group);
        }

        // Main stays clean — menu logic in a separate method
        static void RunMenu(Group group)
        {
            while (true)
            {
                Console.WriteLine("\n--- MENU ---");
                Console.WriteLine("1. Add student");
                Console.WriteLine("2. Show all students");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by Email");
                Console.WriteLine("0. Exit");
                Console.Write("Choose: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddStudentMenu(group);
                        break;

                    case "2":
                        group.PrintAll();
                        break;

                    case "3":
                        SearchById(group);
                        break;

                    case "4":
                        SearchByEmail(group);
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void AddStudentMenu(Group group)
        {
            Console.WriteLine("\n--- Add Student ---");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("First Name: ");
            string first = Console.ReadLine();

            Console.Write("Last Name: ");
            string last = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            List<double> grades = ReadGrades();

            Student student = new Student(id, first, last, email, grades);

            // Validation
            if (!Validator.ValidateStudent(student))
            {
                Console.WriteLine("Student not added due to validation errors.");
                return;
            }

            group.AddStudent(student);
            Console.WriteLine("Student added successfully!");
        }

        static List<double> ReadGrades()
        {
            List<double> grades = new List<double>();
            Console.WriteLine("Enter grades separated by commas (example: 5,6,8):");

            string input = Console.ReadLine();
            string[] parts = input.Split(',');

            foreach (string p in parts)
            {
                if (double.TryParse(p.Trim(), out double grade))
                {
                    grades.Add(grade);
                }
            }

            return grades;
        }

        static void SearchById(Group group)
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Student st = group.FindById(id);

            if (st == null)
                Console.WriteLine("Student NOT found.");
            else
                st.PrintInfo();
        }

        static void SearchByEmail(Group group)
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Student st = group.FindByEmail(email);

            if (st == null)
                Console.WriteLine("Student NOT found.");
            else
                st.PrintInfo();
        }
    }
}
