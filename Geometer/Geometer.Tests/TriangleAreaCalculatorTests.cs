using Geometer.AreaCalculators;

namespace Geometer.Tests;

public class TriangleAreaCalculatorTests
{
    [TestCase(4, 5, 7, 9.80)]
    [TestCase(34, 23, 12, 66.81)]
    [TestCase(156, 234, 138, 10381.49)]
    public void CalculateTriangleAreaTest(double firstSide, double secondSide, double thirdSide, double expected)
    {
        var calculator = new TriangleAreaCalculator(firstSide, secondSide, thirdSide);

        double actual = Math.Round(calculator.CalculateArea(), 2);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
