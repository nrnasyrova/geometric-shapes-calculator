using GeometricShapesCalculator.Interfaces;

namespace GeometricShapesCalculator.Shapes;

public class Triangle: ITriangle
{
    private double Side1 { get; }
    private double Side2 { get; }
    private double Side3 { get; }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
        
        if (!IsValidTriangle())
        {
            throw new ArgumentException("Invalid triangle");
        }
    }

    public double CalculateArea()
    {
        var semiPerimeter = CalculatePerimeter() / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
    }

    public double CalculatePerimeter()
    {
        return Side1 + Side2 + Side3;
    }
    
    public bool IsRightTriangle()
    {
        return Math.Pow(GetLongestSide(), 2) - (Math.Pow(GetShortestSide(), 2) - Math.Pow(GetMiddleSide(), 2)) == 0.0;
    }

    private bool IsValidTriangle()
    {
        return Side1 + Side2 > Side3 &&
               Side2 + Side3 > Side1 &&
               Side1 + Side3 > Side2;
    }
    
    private double GetLongestSide()
    {
        return Math.Max(Math.Max(Side1, Side2), Side3);
    }

    private double GetShortestSide()
    {
        return Math.Min(Math.Min(Side1, Side2), Side3);
    }

    private double GetMiddleSide()
    {
        return Side1 + Side2 + Side3 - GetLongestSide() - GetShortestSide();
    }
}