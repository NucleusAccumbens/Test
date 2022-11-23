using Geometer.Exceptions;
using Geometer.GeomFigures;

namespace Geometer.Tests;

public class TriangleTests
{
    [TestCase(1, 2, 14)]
    [TestCase(-7, 6, 28)]
    [TestCase(0, 8, 29)]
    public void CreateTriangleTest(double firstSide, double secondSide, double thirdSide)
    {
        Assert.Throws<TriangleExistingException>(() => new Triangle(firstSide, secondSide, thirdSide));
    }

    [TestCase(8, 7, 9, false)]
    [TestCase(10, 15, 23, false)]
    [TestCase(3, 4, 5, true)]
    [TestCase(5, 12, 13, true)]
    public void IsRightTriangleTest(double firstSide, double secondSide, double thirdSide, bool expected)
    {
        var triangle = new Triangle(firstSide, secondSide, thirdSide);

        bool actual = triangle.IsRightTriangle();

        Assert.That(actual, Is.EqualTo(expected));
    }
}
