public class Rectangle : GeometricFigure
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Width and height must be positive values.");
        
        this.width = width;
        this.height = height;
    }

    public override double Perimeter => 2 * (width + height);

    public override double Area => width * height;

    public override void Draw(Canvas canvas)
    {
        canvas.DrawRectangle(this);
    }
}
