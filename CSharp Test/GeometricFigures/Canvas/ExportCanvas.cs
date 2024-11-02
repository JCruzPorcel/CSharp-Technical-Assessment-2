using System.IO;

public class ExportCanvas : Canvas
{
    private string filePath;

    public ExportCanvas(string filePath)
    {
        this.filePath = filePath;
    }

    public override void DrawTriangle(Triangle triangle)
    {
        File.AppendAllText(filePath, $"Triangle: Perimeter: {triangle.Perimeter}, Area: {triangle.Area}\n");
    }

    public override void DrawRectangle(Rectangle rectangle)
    {
        File.AppendAllText(filePath, $"Rectangle: Perimeter: {rectangle.Perimeter}, Area: {rectangle.Area}\n");
    }

    public override void DrawCircle(Circle circle)
    {
        File.AppendAllText(filePath, $"Circle: Perimeter: {circle.Perimeter}, Area: {circle.Area}\n");
    }
}
