public class Circle : GeometricFigure
{
    private double radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be a positive value.");
        
        this.radius = radius;
    }

    public override double Perimeter => 2 * Math.PI * radius;

    public override double Area => Math.PI * radius * radius;

    public override void Draw(Canvas canvas)
    {
        canvas.DrawCircle(this);
    }
}
