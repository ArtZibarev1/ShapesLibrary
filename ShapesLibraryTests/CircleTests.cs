using ShapeLibrary.Services;
using ShapeLibrary.Shapes2D;

namespace ShapesLibraryTests;

public class CircleTests
{
    [Fact]
    public void NegativeRadiusTest()
    {
        Assert.Throws<ArgumentException>(() => new Circle(new MathProvider(), -1));
    }
    
    [Fact]
    public void ZeroRadiusTest()
    {
        Assert.Throws<ArgumentException>(() => new Circle(new MathProvider(), 0));
    } 
    
    [Fact]
    public void MaxDoubleRadiusTest()
    {
        var mathProvider = new MathProvider();
        
        var circle = new Circle(mathProvider, double.MaxValue);
        
        Assert.Equal(Double.PositiveInfinity, circle.Area);    
    } 
    
    [Theory]
    [InlineData(1)]
    [InlineData(1000.01)]
    public void AreaSizeWithPositiveRadiusTest(double radius)
    {
        var mathProvider = new MathProvider();
        
        var circle = new Circle(mathProvider, radius);
        
        Assert.Equal(radius * mathProvider.PI, circle.Area);
    }
}