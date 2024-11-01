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

        // Acomodar buses en los espacios grandes
        int busesInBigSlots = Math.Min(buses, bigSlots);
        occupiedSlots += busesInBigSlots;
        bigSlots -= busesInBigSlots;
        buses -= busesInBigSlots;

        // Acomodar autos en los espacios grandes
        int carsInBigSlots = Math.Min(cars, bigSlots * 3);
        occupiedSlots += (carsInBigSlots + 2) / 3; 
        cars -= carsInBigSlots;

        // Acomodar autos en los espacios pequeños
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

        // Acomodar buses en los espacios grandes
        result.BigSlotsOccupiedByBuses = Math.Min(buses, bigSlots);
        bigSlots -= result.BigSlotsOccupiedByBuses; // Resta los espacios ocupados por buses
        buses -= result.BigSlotsOccupiedByBuses; // Resta los buses acomodados

        if (cars > 0)
        {
            // Acomodar autos en los espacios grandes
            int carsInBigSlots = Math.Min(cars, bigSlots * 3);
            result.BigSlotsOccupiedByCars = (int)Math.Ceiling(carsInBigSlots / 3.0);

            // Si hay un bus y solo un auto, el auto no puede usar espacio grande
            if (result.BigSlotsOccupiedByBuses > 0 && cars == 1)
            {
                result.BigSlotsOccupiedByCars = 0; 
            }

            // Resta los autos acomodados en espacios grandes
            cars -= carsInBigSlots;
        }

        // Acomodar autos en los espacios pequeños
        result.SmallSlotsOccupiedByCars = Math.Min(cars, smallSlots);
        cars -= result.SmallSlotsOccupiedByCars; // Resta los autos acomodados en espacios pequeños

        // Autos y buses que no están acomodados
        result.CarsNotParked = cars;
        result.BusesNotParked = buses;

        // Cálculo de espacios libres
        result.BigSlotsFree = bigSlots; // Los espacios grandes que quedan
        result.SmallSlotsFree = smallSlots - result.SmallSlotsOccupiedByCars; // Espacios pequeños libres

        return result;
    }
}
