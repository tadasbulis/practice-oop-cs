using System;
using System.Collections.Generic;

namespace uzduotis3
{
    internal class Group
    {
        // sukuriamas listas
        private List<StudentasClass> students = new List<StudentasClass>();

        public void AddStudent(StudentasClass student)
        {
            students.Add(student);
        }

        // printina visus studentus, nebent nera ka printint
        public void PrintAll()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Grupė tuščia.");
                return;
            }

            foreach (StudentasClass s in students)
            {
                s.Print();
            }
        }
    }
}