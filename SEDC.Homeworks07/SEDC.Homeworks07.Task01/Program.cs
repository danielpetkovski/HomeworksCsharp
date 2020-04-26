using SEDC.Homeworks07.Task01.Enums;
using SEDC.Homeworks07.Task01.Models;
using System;

namespace SEDC.Homeworks07.Task01
{
    class Program
    {
        

        static void Main(string[] args)
        {


            ElectricCar toyota = new ElectricCar("Toyota", "Auris", 3, 130, Consumption.Economic, 120, 10);
            ElectricCar honda = new ElectricCar("Honda", "Civic", 3, 160, Consumption.Medium, 130, 20);
            ElectricCar hyundai = new ElectricCar("Hyundai", "Limo", 5, 190, Consumption.High, 150, 38);
            ElectricCar toyota2 = new ElectricCar("Toyota", "Celica", 5, 150, Consumption.Medium, 140, 15);




            FuelCar bmw = new FuelCar("BMW", "535i", 3, 220, Consumption.High, EngineType.Petrol, 60, 40);
            FuelCar mercedes = new FuelCar("Mercedes", "GLS", 5, 200, Consumption.High, EngineType.Diesel, 80, 60);
            FuelCar audi = new FuelCar("Audi", "A3", 3, 205, Consumption.Medium, EngineType.Petrol, 55, 38);
            FuelCar opel = new FuelCar("Opel", "Astra", 3, 190, Consumption.Economic, EngineType.Diesel, 65, 42);

            Console.WriteLine(bmw.Drive(60));
            Console.WriteLine(toyota.Drive(24));

            
            Console.ReadLine();
        }
    }
}
