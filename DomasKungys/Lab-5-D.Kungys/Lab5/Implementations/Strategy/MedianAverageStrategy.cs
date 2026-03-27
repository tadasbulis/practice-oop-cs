using Lab5.Interfaces;
using Lab5.Models;

namespace Lab5.Implementations.Strategy;

/// <summary>
/// Median strategy: sorts grades and returns the middle value
/// (average of two middle values when count is even).
/// </summary>
public class MedianAverageStrategy : IAverageStrategy
{
    public double Calculate(Student student)
    {
        if (student.Grades.Count == 0)
            return 0;

        var sorted = student.Grades.OrderBy(g => g).ToList();
        int mid = sorted.Count / 2;

        if (sorted.Count % 2 == 1)
            return sorted[mid];

        return (sorted[mid - 1] + sorted[mid]) / 2.0;
    }
}
