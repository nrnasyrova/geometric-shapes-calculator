using System;
using GeometricShapesCalculator.Shapes;
using Xunit;

namespace GeometricShapesCalculator.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(0)]
    [InlineData(-2)]
    [InlineData(-50)]
    public void InvalidCircle_ThrowsArgumentException(int radius)
    { 
        // Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }

    [Theory]
    [InlineData(2, 12.57)]
    [InlineData(5, 78.54)]
    [InlineData(110, 38013.27)]
    public void CalculateArea_ValidCircle_ReturnsExpectedResult(int radius, int expectedArea)
    {
        // Arrange
        var circle = new Circle(radius);

        // Act
        var result = circle.CalculateArea();

        // Assert
        Assert.Equal(expectedArea, result, 0);
    }
    
}