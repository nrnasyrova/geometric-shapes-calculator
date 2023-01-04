using GeometricShapesCalculator.Interfaces;

namespace GeometricShapesCalculator.Shapes;

public class Circle: ICircle
{
    private double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
        
        if (!IsValidCircle())
        {
            throw new ArgumentException("Invalid circle");
        }
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double CalculateDiameter()
    {
        return Radius * 2;
    }

    private bool IsValidCircle()
    {
        return Radius > 0;
    }
}