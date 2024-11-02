using System;

class Program
{
    static void Main(string[] args)
    {
        double valueA = 10;
        double valueB = 3;
        double totalSum, averageResult;

        CalculateSumAndAverage(valueA, valueB, out totalSum, out averageResult);

        Console.WriteLine($"Total Sum (r0): {totalSum}");
        Console.WriteLine($"Average Result (r1): {averageResult}");
    }

    static void CalculateSumAndAverage(double valueA, double valueB, out double sum, out double average)
    {
        int numberOfElements = (int)Math.Floor(valueA / valueB) + 1;

        double totalSum = 0;
        for (int i = 0; i <= numberOfElements; i++)
        {
            totalSum += i * valueA * valueB;
        }

        sum = totalSum;
        average = numberOfElements > 0 ? totalSum / numberOfElements : 0;
    }
}
