
using Lab5.Interfaces;
using Lab5.Models;

namespace Lab5.Implementations.Strategy;

public class WeightedAverageStrategy : IAverageStrategy
{
    private readonly List<double> _weights = new();

    public WeightedAverageStrategy()
    {
        _weights.Add(1.5);
        _weights.Add(1.0);
        _weights.Add(1.0);
    }

    public double Calculate(Student student)
    {
        if (student.Grades.Count == 0)
            return 0;

        double weightedSum = 0;
        double weightSum = 0;

        for (int i = 0; i < student.Grades.Count; i++)
        {
            double weight = i < _weights.Count ? _weights[i] : 1.0;
            weightedSum += student.Grades[i] * weight;
            weightSum += weight;
        }

        return weightSum > 0 ? weightedSum / weightSum : 0;
    }
}
