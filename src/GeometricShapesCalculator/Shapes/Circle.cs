using GeometricShapesCalculator.Interfaces;

namespace GeometricShapesCalculator.Shapes;

public class Circle: ICircle
{
    private double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
        
        if (!IsValidShape())
        {
            throw new ArgumentException("Invalid circle");
        }
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Sqrt(Radius);
    }

    public double CalculateDiameter()
    {
        return Radius * 2;
    }

    private bool IsValidShape()
    {
        return Radius > 0;
    }
}