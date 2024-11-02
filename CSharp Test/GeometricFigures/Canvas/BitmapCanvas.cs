public class BitmapCanvas : Canvas
{
    public override void DrawTriangle(Triangle triangle)
    {
        Console.WriteLine($"Drawing triangle with perimeter: {triangle.Perimeter} and area: {triangle.Area}");
    }

    public override void DrawRectangle(Rectangle rectangle)
    {
        Console.WriteLine($"Drawing rectangle with perimeter: {rectangle.Perimeter} and area: {rectangle.Area}");
    }

    public override void DrawCircle(Circle circle)
    {
        Console.WriteLine($"Drawing circle with perimeter: {circle.Perimeter} and area: {circle.Area}");
    }
}
