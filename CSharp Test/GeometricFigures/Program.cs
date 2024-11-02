using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Triangle triangle = null;

        while (triangle == null)
        {
            try
            {
                double triangleSide1 = GetValidInput("Enter the length of the first side of the triangle:");
                double triangleSide2 = GetValidInput("Enter the length of the second side of the triangle:");
                double triangleSide3 = GetValidInput("Enter the length of the third side of the triangle:");
                
                triangle = new Triangle(triangleSide1, triangleSide2, triangleSide3);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Input for Rectangle
        double rectangleWidth = GetValidInput("Enter the width of the rectangle:");
        double rectangleHeight = GetValidInput("Enter the height of the rectangle:");
        
        var rectangle = new Rectangle(rectangleWidth, rectangleHeight);

        // Input for Circle
        double circleRadius = GetValidInput("Enter the radius of the circle:");
        
        var circle = new Circle(circleRadius);

        // Use BitmapCanvas
        var bitmapCanvas = new BitmapCanvas();
        triangle.Draw(bitmapCanvas);
        rectangle.Draw(bitmapCanvas);
        circle.Draw(bitmapCanvas);

        // Define the output directory and file name
        string outputDirectory = "Output";
        string fileName = "figures.txt";
        string filePath = Path.Combine(outputDirectory, fileName);

        if (!Directory.Exists(outputDirectory))
        {
            Directory.CreateDirectory(outputDirectory);
        }

        // Use ExportCanvas
        var exportCanvas = new ExportCanvas(filePath);
        triangle.Draw(exportCanvas);
        rectangle.Draw(exportCanvas);
        circle.Draw(exportCanvas);
    }

    static double GetValidInput(string prompt)
    {
        double result;
        while (true)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out result) && result > 0)
            {
                return result; 
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }
}
