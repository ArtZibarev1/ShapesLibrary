using ShapeLibrary.Services;
using ShapeLibrary.Shapes2D;

namespace ShapesLibraryTests;

public class TriangleTests
{
    [Theory]
    [InlineData(-1, 2, 3)]
    [InlineData(1, -2, 3)]
    [InlineData(1, 2, -3)]
    public void NegativeSideTest(double AB, double AC, double BC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(new MathProvider(), AB, AC, BC));
    }
    
    [Theory]
    [InlineData(0, 2, 3)]
    [InlineData(1, 0, 3)]
    [InlineData(1, 2, 0)]
    public void ZeroSideTest(double AB, double AC, double BC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(new MathProvider(), AB, AC, BC));
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(100.01, 2.01, 3.03)]
    public void AreaSizeWithPositiveSidesTest(double AB, double AC, double BC)
    {
        var triangle = new Triangle(new MathProvider(), AB, AC, BC);
        
        var halfPerimeter = (AB + AC + BC) / 2;

        var area = Math.Sqrt(halfPerimeter * (halfPerimeter - AB) * (halfPerimeter - AC) * (halfPerimeter
            - BC));

        Assert.Equal(area, triangle.Area);
    }
}