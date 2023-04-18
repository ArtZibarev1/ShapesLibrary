using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Services;

public class MathProvider : IMathProvider
{
    public double PI => Math.PI;
}