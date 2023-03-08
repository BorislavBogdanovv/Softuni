using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarManufacturer
{
    public class Car
    {
        private string make;  // това са полета
        private string model; // това са полета
        private int year;  // това са полета

        private double fuelConsumption;
        private double fuelQuantity;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) :this(make, model, year) // с this(...) така не трябва да пишем пак всичко от горния конструктор, като го подадем
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }


        public string Make { get { return make; } set { make = value; } }  //това са пропъртита
        public string Model { get { return model; } set { model = value; } }  //това са пропъртита
        public int Year { get { return year; } set { year = value; } }  //това са пропъртита
        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }  //това са пропъртита
        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }  //това са пропъртита

        public void Drive(double distance)
        {
            double neededFuel = distance * fuelConsumption;

            if (neededFuel < fuelQuantity)
            {
                fuelQuantity -= neededFuel;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.AppendLine($"Fuel: {this.FuelQuantity:f2}");

            return result.ToString().Trim();
        }
    }
}
