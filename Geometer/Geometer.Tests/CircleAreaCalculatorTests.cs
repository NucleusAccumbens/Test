using Geometer.AreaCalculators;

namespace Geometer.Tests;

[TestFixture]
public class CircleAreaCalculatorTests
{
    [TestCase(10, 314.16)]
    [TestCase(15, 706.86)]
    [TestCase(18, 1017.88)]
    public void CalculateCircleAreaTest(double radius, double expected)
    {
        var calculator = new CircleAreaCalculator(radius);

        double actual = Math.Round(calculator.CalculateArea(), 2);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
