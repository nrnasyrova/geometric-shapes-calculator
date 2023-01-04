using System;
using GeometricShapesCalculator.Shapes;
using Xunit;

namespace GeometricShapesCalculator.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(-2, -4, -8)]
    [InlineData(10, 5, 4)]
    public void InvalidTriangle_ThrowsArgumentException(int side1, int side2, int side3)
    { 
        // Assert
        Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
    }
    
    [Theory]
    [InlineData(3,4,5,6)]
    [InlineData(5,6,9,14.142136)]
    public void CalculateArea_ValidTriangle_ReturnsExpectedResult(int side1, int side2, int side3, int expectedArea)
    {
        // Arrange
        var triangle = new Triangle(side1, side2, side3);

        // Act
        var result = triangle.CalculateArea();

        // Assert
        Assert.Equal(expectedArea, result, 0);
    }
    
    [Theory]
    [InlineData(3,5,4, true)]
    [InlineData(8,17,15, true)]
    [InlineData(6, 8, 10, true)]
    [InlineData(6, 7, 10, false)]
    [InlineData(5, 5, 7, false)]
    public void IsRightTriangle_ValidTriangle_ReturnsExpectedResult(int side1, int side2, int side3, bool expectedResult)
    {
        // Arrange
        var triangle = new Triangle(side1, side2, side3);

        // Act
        var result = triangle.IsRightTriangle();

        // Assert
        Assert.Equal(expectedResult, result);
    }
}