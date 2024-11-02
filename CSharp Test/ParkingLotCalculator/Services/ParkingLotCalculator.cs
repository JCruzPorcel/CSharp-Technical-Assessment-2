public static class ParkingLotCalculator
{
    public static int CalculateMinSlots(int bigSlots, int smallSlots, int buses, int cars)
    {
        if (bigSlots < 0 || smallSlots < 0 || buses < 0 || cars < 0)
        {
            throw new ArgumentException("Number of slots and vehicles must be non-negative.");
        }

        if (buses == 0 && cars == 0)
        {
            return 0;
        }

        int occupiedSlots = 0;

        int busesInBigSlots = Math.Min(buses, bigSlots);
        occupiedSlots += busesInBigSlots;
        bigSlots -= busesInBigSlots;
        buses -= busesInBigSlots;

        int carsInBigSlots = Math.Min(cars, bigSlots * 3);
        occupiedSlots += (carsInBigSlots + 2) / 3; 
        cars -= carsInBigSlots;

        int carsInSmallSlots = Math.Min(cars, smallSlots);
        occupiedSlots += carsInSmallSlots;

        return occupiedSlots;
    }

    public static ParkingLotStatus CalculateParkingDetails(int bigSlots, int smallSlots, int buses, int cars)
    {
        if (bigSlots < 0 || smallSlots < 0 || buses < 0 || cars < 0)
            throw new ArgumentException("Number of slots and vehicles must be non-negative.");

        var result = new ParkingLotStatus();

        if (buses == 0 && cars == 0)
            return result;

        result.BigSlotsOccupiedByBuses = Math.Min(buses, bigSlots);
        bigSlots -= result.BigSlotsOccupiedByBuses;
        buses -= result.BigSlotsOccupiedByBuses; 

        if (cars > 0)
        {
            int carsInBigSlots = Math.Min(cars, bigSlots * 3);
            result.BigSlotsOccupiedByCars = (int)Math.Ceiling(carsInBigSlots / 3.0);

            if (result.BigSlotsOccupiedByBuses > 0 && cars == 1)
            {
                result.BigSlotsOccupiedByCars = 0; 
            }

            cars -= carsInBigSlots;
        }

        result.SmallSlotsOccupiedByCars = Math.Min(cars, smallSlots);
        cars -= result.SmallSlotsOccupiedByCars; 

        result.CarsNotParked = cars;
        result.BusesNotParked = buses;

        result.BigSlotsFree = bigSlots;
        result.SmallSlotsFree = smallSlots - result.SmallSlotsOccupiedByCars;

        return result;
    }
}
