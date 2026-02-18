using System;

namespace Lab1.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Jonas");
            s1.Grades.Add(8);
            s1.Grades.Add(9);
            s1.Grades.Add(7);

            Student s2 = new Student("Ona");
            s2.Grades.Add(10);
            s2.Grades.Add(9);
            s2.Grades.Add(10);

            Student s3 = new Student("Tomas");
            s3.Grades.Add(6);
            s3.Grades.Add(7);
            s3.Grades.Add(8);

            s1.PrintInfo();
            s2.PrintInfo();
            s3.PrintInfo();
        }
    }
}
