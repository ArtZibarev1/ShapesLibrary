using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Abstracts;

public abstract class Shape
{
    public Shape(IMathProvider mathProvider)
    {
        MathProvider = mathProvider;
    }
    
    internal readonly IMathProvider MathProvider;
}