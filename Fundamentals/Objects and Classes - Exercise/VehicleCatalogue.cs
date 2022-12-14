using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = arguments[0].ToLower();
                string model = arguments[1];
                string color = arguments[2].ToLower();
                int horsePower = int.Parse(arguments[3]);

                var currentVehicle = new Vehicle(type, model, color, horsePower);
                catalogue.Add(currentVehicle);
            }

            string searchModel;
            while ((searchModel = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(catalogue.Find(x => x.Model == searchModel));
            }

            var onlyCars = catalogue.Where(x => x.Type == "car").ToList();

            var onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();

            double totalCarsHorsePower = 0;

            double totalTrucksHorsePower = 0;

            foreach (var car in onlyCars)
            {
                totalCarsHorsePower += car.HorsePower;
            }

            foreach (var truck in onlyTrucks)
            {
                totalTrucksHorsePower += truck.HorsePower;
            }

            double averageCarsHorsePower = totalCarsHorsePower / onlyCars.Count;

            double averageTrucksHorsePower = totalTrucksHorsePower / onlyTrucks.Count;

            if (onlyCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsePower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (onlyTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsePower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }

    public class Car
    {
        public Car(string typeOfVehicle, string model, string colorOfVehicle, string horsePowerOfVehicle)
        {
            this.Type = typeOfVehicle;
            this.Model = model;
            this.Color = colorOfVehicle;
            this.HorsePower = horsePowerOfVehicle;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public string HorsePower { get; set; }
    }

    public class Vehicle
    {
        public Vehicle(string typeOfVehicle, string model, string colorOfVehicle, int horsePowerOfVehicle)
        {
            this.Type = typeOfVehicle;
            this.Model = model;
            this.Color = colorOfVehicle;
            this.HorsePower = horsePowerOfVehicle;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HorsePower { get; set; }

        public override string ToString()
        {
            string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                $"Model: {this.Model}{Environment.NewLine}" +
                                $"Color: {this.Color}{Environment.NewLine}" +
                                $"Horsepower: {this.HorsePower}";

            return vehicleStr;
        }
    }
}
