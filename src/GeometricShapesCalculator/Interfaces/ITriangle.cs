namespace GeometricShapesCalculator.Interfaces;

public interface ITriangle: IShape
{
    bool IsRightTriangle();
    double CalculatePerimeter();
}