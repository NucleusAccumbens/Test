using Geometer.Interfaces;

namespace Geometer.Abstractions;

public abstract class BaseGeomFigure
{
    private IAreaCalculator _areaCalculator;

    public  BaseGeomFigure(IAreaCalculator areaCalculator)
    {
        _areaCalculator = areaCalculator;
    }

    public double GetArea()
    {
        return _areaCalculator.CalculateArea();
    }
}
