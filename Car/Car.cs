namespace Car
{
    public class Car
    {
        public decimal fuelEfficiency;
        public int amountOfFuel;

        public Car(decimal fuelEfficiency)
        {
            FuelEfficiency = fuelEfficiency;
            AmountOfFuel = amountOfFuel;
            AmountOfFuel = 0;
        }

        public decimal FuelEfficiency { get; set; }
        public int AmountOfFuel { get; set; }
    }
}