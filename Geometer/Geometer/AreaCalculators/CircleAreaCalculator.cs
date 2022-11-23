using Geometer.Interfaces;

namespace Geometer.AreaCalculators;

public class CircleAreaCalculator : IAreaCalculator
{
    private readonly double _radius;

    public CircleAreaCalculator(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}
