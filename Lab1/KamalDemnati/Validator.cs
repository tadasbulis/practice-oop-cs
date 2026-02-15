using System;

namespace Lab1
{
    internal static class Validator
    {
        public static bool ValidateStudent(Student s)
        {
            bool ok = true;

            if (!s.Email.Contains("@"))
            {
                Console.WriteLine("❌ Invalid email.");
                ok = false;
            }

            double avg = s.GetAverage();
            if (avg < 0 || avg > 10)
            {
                Console.WriteLine("❌ Average must be between 0 and 10.");
                ok = false;
            }

            return ok;
        }
    }
}
