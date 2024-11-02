public class ParkingLotStatus
{
    public int BigSlotsOccupiedByBuses { get; set; }
    public int BigSlotsOccupiedByCars { get; set; }
    public int SmallSlotsOccupiedByCars { get; set; }
    public int BigSlotsFree { get; set; }
    public int SmallSlotsFree { get; set; }
    public int BusesNotParked { get; set; }
    public int CarsNotParked { get; set; }

    public int OccupiedSlots => BigSlotsOccupiedByBuses + BigSlotsOccupiedByCars + SmallSlotsOccupiedByCars;

    public override string ToString()
    {
        return $"Big slots occupied by buses: {BigSlotsOccupiedByBuses}\n" +
               $"Big slots occupied by cars: {BigSlotsOccupiedByCars}\n" +
               $"Small slots occupied by cars: {SmallSlotsOccupiedByCars}\n" +
               $"Big slots free: {BigSlotsFree}\n" +
               $"Small slots free: {SmallSlotsFree}\n" +
               $"Buses not parked: {BusesNotParked}\n" +
               $"Cars not parked: {CarsNotParked}";
    }
}
