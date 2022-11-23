using Geometer.Interfaces;

namespace Geometer.AreaCalculators;

public class TriangleAreaCalculator : IAreaCalculator
{
    private readonly double _firstSide;

    private readonly double _secondSide;

    private readonly double _thirdSide;

    public TriangleAreaCalculator(double firstSide, double secondSide, double thirdSide)
    {
        _firstSide = firstSide;
        _secondSide = secondSide;
        _thirdSide = thirdSide;
    }

    public double CalculateArea()
    {
        double semiPer = (_firstSide + _secondSide + _thirdSide) / 2;

        return Math
            .Sqrt(semiPer * (semiPer - _firstSide) * (semiPer - _secondSide) * (semiPer - _thirdSide));
    }
}
