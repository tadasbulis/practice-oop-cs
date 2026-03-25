
using Lab5.Interfaces;
using Lab5.Models;

namespace Lab5.Implementations.Strategy;

public class MedianAverageStrategy : IAverageStrategy
{
    public double Calculate(Student student)
    {
        if (student.Grades.Count == 0)
            return 0;

        var sortedGrades = student.Grades.OrderBy(g => g).ToList();
        int count = sortedGrades.Count;

        if (count % 2 == 0)
        {
            return (sortedGrades[count / 2 - 1] + sortedGrades[count / 2]) / 2.0;
        }
        else
        {
            return sortedGrades[count / 2];
        }
    }
}
