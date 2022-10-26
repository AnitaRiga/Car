namespace Car
{
    public class PetrolStation
    {
        private static int randomDistance;
        private static decimal fuelConsumption;
        private static int addedFuel;
        private static decimal fuelRemaining;
        private const int tankSize = 83;

        public decimal GetRandomDistance()
        {
            Random rnd = new Random();
            randomDistance = rnd.Next(1, 640);

            Console.WriteLine($"The distance to your destination is {randomDistance} km.");

            return randomDistance;
        }

        public string GetFuelLevel(Car bmw)
        {
            fuelConsumption = Math.Round(randomDistance * bmw.FuelEfficiency, 2);

            Console.WriteLine($"You must fill up, you're out of petrol. Enter the number of liters from {Math.Round(fuelConsumption, 0)} till {tankSize}." + "\r\n");

            do
            {
                bool isNumeric = int.TryParse(Console.ReadLine(), out addedFuel) && addedFuel >= fuelConsumption && addedFuel <= tankSize;

                if (isNumeric)
                {
                    Console.WriteLine($"A gas tank is filled with {addedFuel} liters of petrol." + "\r\n");
                    return addedFuel.ToString();
                }
                else
                {
                    Console.WriteLine($"Please input a numeric from {Math.Round(fuelConsumption, 0)} till {tankSize}.");
                }

            } while (true);
        }

        public void GetFuelRemaining()
        {
            fuelRemaining = addedFuel - fuelConsumption;
            Console.WriteLine($"You Have Arrived at Your Destination. Fuel remaining is {fuelRemaining} l.");
        }
    }
}