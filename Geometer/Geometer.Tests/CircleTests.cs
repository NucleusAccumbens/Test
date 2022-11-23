using Geometer.Exceptions;
using Geometer.GeomFigures;

namespace Geometer.Tests;

public class CircleTests
{
    [TestCase(-746)]
    [TestCase(-3)]
    [TestCase(0)]
    public void CreateCircleTest(double radius)
    {
        Assert.Throws<CircleExistingException>(() => new Circle(radius));
    }
}
