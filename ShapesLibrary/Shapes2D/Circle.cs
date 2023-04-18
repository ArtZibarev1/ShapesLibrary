using ShapeLibrary.Abstracts;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Shapes2D;

public class Circle : Shape2D, IHaveRadius
{
    public Circle(IMathProvider mathProvider, double radius) : base(mathProvider)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius should be greater than 0");
        }

        Radius = radius;
    }
    
    public double Radius { get; }
    
    public override double Area => Radius * MathProvider.PI;
    
    public override double Perimeter => 2 * MathProvider.PI * Radius;
}