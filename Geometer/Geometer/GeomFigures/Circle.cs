using Geometer.Abstractions;
using Geometer.AreaCalculators;
using Geometer.Exceptions;
using Geometer.Interfaces;

namespace Geometer.GeomFigures;

public class Circle : BaseGeomFigure
{
    private readonly double _radius;

    public Circle(double radius)
        : base(new CircleAreaCalculator(radius))
    {
        if (radius > 0)
        {
            _radius = radius;
        }

        else throw new CircleExistingException();
    }

    public double Radius => _radius;
}
