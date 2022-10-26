namespace Car
{
    //BMW X7 M60i xDrive, Tank Capacity: 83 l, Fuel Consumption Combined in l/100: km 12.9-12.1
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car(0.129M);

            PetrolStation petrolStation = new PetrolStation();

            petrolStation.GetRandomDistance();

            petrolStation.GetFuelLevel(bmw);

            petrolStation.GetFuelRemaining();
        }
    }
}