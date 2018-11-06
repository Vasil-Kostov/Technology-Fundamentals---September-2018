namespace _06._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            long carsHorsePower = 0;
            long trucksHorsePower = 0;

            int carCounter = 0;
            int truckCounter = 0;

            string input = Console.ReadLine();

            while (input != "End")
            {
                Vehicle currentVehicle = new Vehicle(input.Split());

                if (currentVehicle.Type.ToLower() == "car")
                {
                    carsHorsePower += currentVehicle.HorsePower;
                    carCounter++;

                    currentVehicle.Type = "Car";
                }
                else if (currentVehicle.Type.ToLower() == "truck")
                {
                    trucksHorsePower += currentVehicle.HorsePower;
                    truckCounter++;

                    currentVehicle.Type = "Truck";
                }

                vehicles.Add(currentVehicle);

                input = Console.ReadLine();
            }

            string modelToPrint = Console.ReadLine();

            while (modelToPrint != "Close the Catalogue")
            {
                foreach (var vehicle in vehicles.Where(v => v.Model == modelToPrint))
                {
                    Console.WriteLine($"Type: {vehicle.Type}");
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                }

                modelToPrint = Console.ReadLine();
            }

            if (carCounter > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsHorsePower / (double)carCounter:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }
            if (truckCounter > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksHorsePower / (double)truckCounter:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }

        }
    }

    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Vehicle(string[] vehicleInfo)
        {
            this.Type = vehicleInfo[0];
            this.Model = vehicleInfo[1];
            this.Color = vehicleInfo[2];
            this.HorsePower = int.Parse(vehicleInfo[3]);
        }
    }

}
