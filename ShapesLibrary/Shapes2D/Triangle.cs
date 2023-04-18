using ShapeLibrary.Abstracts;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Shapes2D;

public class Triangle : Shape2D
{
    public Triangle(IMathProvider mathProvider, double pointsAB, double pointsAC, double pointsBC) 
        : base(mathProvider)
    {
        if (pointsAB <= 0 || pointsAC <= 0 || pointsBC <= 0)
        {
            throw new ArgumentException("Sides should be greater than 0");
        }
        
        PointsAB = pointsAB;
        PointsAC = pointsAC;
        PointsBC = pointsBC;
    }

    public double PointsAB { get; }
    
    public double PointsAC { get; }

    public double PointsBC { get; }

    public override double Perimeter => PointsAB + PointsAC + PointsBC;

    public override double Area
    {
        get
        {
            var halfPerimeter = Perimeter / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - PointsAB) * (halfPerimeter - PointsAC) * (halfPerimeter
                - PointsBC));
        }
    }
}