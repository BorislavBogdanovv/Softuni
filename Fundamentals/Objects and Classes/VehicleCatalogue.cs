using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  List<Car> cars = new List<Car>();
          //
          //  List<Truck> trucks = new List<Truck>();

            Catalog catalog = new Catalog();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split('/');

                string type = cmdArgs[0];
                string brand = cmdArgs[1];
                string model = cmdArgs[2];
                int weightOrHP = int.Parse(cmdArgs[3]);

                if (type == "Car")
                {
                    Car car = new Car(brand, model, weightOrHP);
                    catalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck = new Truck(brand, model, weightOrHP);
                    catalog.Trucks.Add(truck);
                }
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars: ");

                foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
                if (catalog.Trucks.Count > 0)
                {
                    Console.WriteLine("Trucks: ");

                    foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
                    {
                        Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                    }
                }
            }
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }

    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }
        
        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }

}
