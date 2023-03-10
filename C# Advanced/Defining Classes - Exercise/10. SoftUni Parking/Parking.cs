using System;
using System.Collections.Generic;

namespace SoftUniParking;

public class Parking
{
    private Dictionary<string, Car> carsByRegistrationNumber;
    private int capacity;

    public Parking(int capacity)
    {
        this.capacity = capacity;
        carsByRegistrationNumber = new Dictionary<string, Car>();
    }

    public int Count 
    { 
        get 
        { 
            return carsByRegistrationNumber.Count; 
        } 
    }

    public string AddCar(Car car)
    {
        if (carsByRegistrationNumber.ContainsKey(car.RegistrationNumber))
        {
            return "Car with that registration number, already exists!";
        }

        if (carsByRegistrationNumber.Count >= capacity)
        {
            return "Parking is full!";
        }

        carsByRegistrationNumber.Add(car.RegistrationNumber, car);

        return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
    }

    public string RemoveCar(string registrationNumber)
    {
        if (!carsByRegistrationNumber.ContainsKey(registrationNumber))
        {
            return "Car with that registration number, doesn't exist!";
        }

        carsByRegistrationNumber.Remove(registrationNumber);

        return $"Successfully removed {registrationNumber}";
    }

    public Car GetCar(string registrationNumber)
    {
        return carsByRegistrationNumber[registrationNumber];
    }

    public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
    {
        foreach (var registrationNumber in registrationNumbers)
        {
            RemoveCar(registrationNumber);
        }
    }
}
