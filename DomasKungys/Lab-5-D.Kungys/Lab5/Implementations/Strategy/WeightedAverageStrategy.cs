using Lab5.Interfaces;
using Lab5.Models;

namespace Lab5.Implementations.Strategy;

/// <summary>
/// Weighted average: later grades carry progressively more weight.
/// Weight of grade at index i = i + 1  (first grade weight 1, last weight N).
/// </summary>
public class WeightedAverageStrategy : IAverageStrategy
{
    public double Calculate(Student student)
    {
        if (student.Grades.Count == 0)
            return 0;

        double weightedSum = 0;
        double totalWeight = 0;

        for (int i = 0; i < student.Grades.Count; i++)
        {
            double weight = i + 1;
            weightedSum += student.Grades[i] * weight;
            totalWeight += weight;
        }

        return weightedSum / totalWeight;
    }
}
