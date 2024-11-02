using System;

class Program
{
    static void Main(string[] args)
    {
        int bigSlots = UserInputHandler.GetIntInput("Enter the number of big slots:");
        int smallSlots = UserInputHandler.GetIntInput("Enter the number of small slots:");
        int buses = UserInputHandler.GetIntInput("Enter the number of buses:");
        int cars = UserInputHandler.GetIntInput("Enter the number of cars:");

        try
        {
            int occupiedSlots = ParkingLotCalculator.CalculateMinSlots(bigSlots, smallSlots, buses, cars);
            ParkingLotStatus status = ParkingLotCalculator.CalculateParkingDetails(bigSlots, smallSlots, buses, cars);

            Console.WriteLine($"\nMinimum slots occupied: {occupiedSlots}");
            Console.WriteLine(status.ToString());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
