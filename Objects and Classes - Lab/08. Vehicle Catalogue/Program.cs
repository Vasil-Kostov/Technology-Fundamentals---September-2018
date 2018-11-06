namespace _08._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Catalog catalog = new Catalog();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArr = input.Split('/');

                catalog.AddNewVehicle(inputArr);

                input = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (var car in catalog.Cars.OrderBy(c => c.Make))
                {
                    Console.WriteLine($"{car.Make}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in catalog.Trucks.OrderBy(t => t.Make))
                {
                    Console.WriteLine($"{truck.Make}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Truck> Trucks { get; set; } = new List<Truck>();

        public void AddNewVehicle(string[] vehicleInfo)
        {
            string vehicleType = vehicleInfo[0];

            if (vehicleType == "Car")
            {
                this.Cars.Add(new Car(vehicleInfo.Skip(1).ToArray()));
            }
            else if (vehicleType == "Truck")
            {
                this.Trucks.Add(new Truck(vehicleInfo.Skip(1).ToArray()));
            }
        }

    }

    class Truck
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }

        public Truck(string[] truckInfo)
        {
            this.Make = truckInfo[0];
            this.Model = truckInfo[1];
            this.Weight = int.Parse(truckInfo[2]);
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

        public Car(string[] carInfo)
        {
            this.Make = carInfo[0];
            this.Model = carInfo[1];
            this.HorsePower = int.Parse(carInfo[2]);
        }
    }
}
