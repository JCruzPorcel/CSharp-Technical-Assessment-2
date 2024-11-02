public class Triangle : GeometricFigure
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double side1, double side2, double side3)
    {
        if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
        {
            throw new ArgumentException("The provided sides do not form a triangle.");
        }

        this.side1 = side1;
        this.side2 = side2;
        this.side3 = side3;
    }

    public override double Perimeter => side1 + side2 + side3;

    public override double Area
    {
        get
        {
            double s = Perimeter / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
    }

    public override void Draw(Canvas canvas)
    {
        canvas.DrawTriangle(this);
    }
}
