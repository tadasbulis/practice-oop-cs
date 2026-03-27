using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis2
{
    class Average
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Domas", new List<double> { 8, 9, 10, 9 });
            Student student2 = new Student("Benas", new List<double> { 10, 7, 8, 9 });
            Student student3 = new Student("Rokas", new List<double> { 10, 10, 9, 8 });
            Student student4 = new Student("Jonas", new List<double> { 6, 7, 9, 8 });
            Student student5 = new Student("Tadas", new List<double> { 10, 6, 9, 5 });

            student1.PrintInfo();
            student2.PrintInfo();
            student3.PrintInfo();
            student4.PrintInfo();
            student5.PrintInfo();
        }
    }
}
