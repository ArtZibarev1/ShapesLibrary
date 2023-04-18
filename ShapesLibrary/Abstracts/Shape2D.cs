using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Abstracts;

public abstract class Shape2D : Shape
{
    public Shape2D(IMathProvider mathProvider) : base(mathProvider)
    {
        
    }
    
    public abstract double Area { get; }
    
    public abstract double Perimeter { get; }
}