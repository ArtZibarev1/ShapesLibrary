using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes2D;

namespace ShapeLibrary.Services;

public class TriangleService : ITriangleService
{
    public bool IsRight(Triangle triangle)
    {
        if (triangle == default)
        {
            return false;
        }
        
        return (Math.Pow(triangle.PointsAB, 2) + Math.Pow(triangle.PointsAC, 2) - Math.Pow(triangle.PointsBC, 2) == 0) 
               || (Math.Pow(triangle.PointsAB, 2) + Math.Pow(triangle.PointsBC, 2) - Math.Pow(triangle.PointsAC, 2) == 0)
               || (Math.Pow(triangle.PointsAC, 2) + Math.Pow(triangle.PointsBC, 2) - Math.Pow(triangle.PointsAB, 2) == 0);
    }
}