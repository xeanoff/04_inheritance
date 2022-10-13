namespace LAB4
{
    public enum Engine { diesel, gas, gasoline, electric };
    public class Vehicle
    {
        public string? ModelName { get; set; }
        public string? Color { get; set; }
        public string? Engine { get; set; }
        public decimal? Speed { get; set; }
        public int EnginePower { get; set; }
        public string? Brand { get; set; }
        public override string? ToString()
        {
            return $"Model: {ModelName}\nColor: {Color}\nEngine: {Engine}\nSpeed: {Speed}\nEngine power: {EnginePower}\nBrand: {Brand}\n";
        }

    }
    public class WaterVehicle : Vehicle
    {
        public string? Type { get; set; }
        public string? Material { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"Type: {Type}\nMaterial: {Material}";
        }
    }
    public class GroundVehicle : Vehicle
    {
        public string? Type { get; set; }
        public string? Modification { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"Type: {Type}\nMaterial: {Modification}";
        }

    }
    public class AirVehicle : Vehicle
    {
        public string? Type { get; set; }
        public string? AmountOfPropeller { get; set; }
        public override string ToString()
        {
            return base.ToString() + $"Type: {Type}\nMaterial: {AmountOfPropeller}";
        }
    }
    class Program
    {
        static void Main()
        {
            WaterVehicle ship = new();
            GroundVehicle car = new();
            AirVehicle airplane = new();
            ship.Brand = "Gavio Group";
            ship.ModelName = "Sunseeker";
            ship.Speed = 100;

            car.Brand = "Lamborghini";
            car.ModelName = "Huracán";
            car.Speed = 325;

            airplane.Brand = "Airbus";
            airplane.ModelName = "A350F";
            airplane.Speed = 880;

            decimal? maxSpeed = 0;
            Vehicle[] vehicles = { ship, car, airplane };
            foreach(Vehicle vehicle in vehicles)
            {
                if (vehicle.Speed > maxSpeed)
                    maxSpeed = vehicle.Speed;
            }

            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.Speed == maxSpeed)
                    Console.WriteLine("The fastest vehicle:\n" + vehicle.ToString());
            }
        }
    }
}