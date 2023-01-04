using System.Collections.Generic;
using GeometricShapesCalculator.Interfaces;
using GeometricShapesCalculator.Shapes;
using Xunit;

namespace GeometricShapesCalculator.Tests;

public class TestCase
{
    public IShape Shape { get; set; }
    public double ExpectedArea { get; set; }
    public bool ExpectedValidity { get; set; }
}

public class ShapeTests
{
    public static IEnumerable<object[]> TestCases()
    {
        yield return new object[]
        {
            new TestCase { Shape = new Triangle(3, 4, 5), ExpectedArea = 6, ExpectedValidity = true }
        };
        yield return new object[]
        {
            new TestCase { Shape = new Circle(2), ExpectedArea = 12.57, ExpectedValidity = true },
        };
    }

    [Theory]
    [MemberData(nameof(TestCases))]
    public void CalculateArea_ReturnsExpectedResult(TestCase testCase)
    {
        // Act
        var result = testCase.Shape.CalculateArea();

        // Assert
        Assert.Equal(testCase.ExpectedArea, result, 2);
    }
    
}