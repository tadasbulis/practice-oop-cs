using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Student s1 = new Student("Ali", "Ait", new List<double> { 8, 9, 7 });
        Student s2 = new Student("Sara", "Ben", new List<double> { 6, 7, 8 });
        Student s3 = new Student("Omar", "El", new List<double> { 9, 9, 10 });

        s1.PrintInfo();
        s2.PrintInfo();
        s3.PrintInfo();
    }
}
