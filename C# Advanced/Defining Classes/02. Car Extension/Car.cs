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
