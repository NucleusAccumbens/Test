using Geometer.Abstractions;
using Geometer.AreaCalculators;
using Geometer.Exceptions;


namespace Geometer.GeomFigures;

public class Triangle : BaseGeomFigure
{
    private readonly double _firstSide;

    private readonly double _secondSide;

    private readonly double _thirdSide;

    public Triangle(double firstSide, double secondSide, double thirdSide) 
        : base(new TriangleAreaCalculator(firstSide, secondSide, thirdSide))
    {
        if (firstSide + secondSide > thirdSide &&
            secondSide + thirdSide > firstSide &&
            thirdSide + firstSide > secondSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }

        else throw new TriangleExistingException();
    }

    public double FirstSide => _firstSide;

    public double SecondSide => _secondSide;

    public double ThirdSide => _thirdSide;

    public bool IsRightTriangle()
    {
        double hypotenuse = GetHypotenuse();

        if (hypotenuse == _firstSide)
        {
            if (Math.Pow(hypotenuse, 2) == Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2)) return true;

            return false;
        }

        if (hypotenuse == _secondSide)
        {
            if (Math.Pow(hypotenuse, 2) == Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2)) return true;

            return false;
        }

        else if (Math.Pow(hypotenuse, 2) == Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2)) return true;

        return false;
    }

    private double GetHypotenuse()
    {
        return Math.Max(_firstSide, Math.Max(_secondSide, _thirdSide));
    }
}
