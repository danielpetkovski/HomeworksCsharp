using SEDC.Homeworks07.Task01.Models;
using SEDC.Homeworks07.Task01.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homeworks07.Task01.Database
{
    public class Database
    {
        protected ElectricCar[] ElectricCars { get; set; }

        protected FuelCar[] FuelCars { get; set; }

        public Database()
        {
            GenerateCars();
        }

        public void GenerateCars()
        {
            ElectricCars = new ElectricCar[]
            {
                new ElectricCar("Toyota","Auris",3,130,Consumption.Economic,120,10),
                new ElectricCar("Honda","Civic",3,160,Consumption.Medium,130,20),
                new ElectricCar("Hyundai","Limo",5,190,Consumption.High,150,38),
                new ElectricCar("Toyota","Celica",5,150,Consumption.Medium,140,15),
            };

            FuelCars = new FuelCar[]
            {
                new FuelCar("BMW","535i",3,220,Consumption.High,EngineType.Petrol,60,40),
                new FuelCar("Mercedes","GLS",5,200,Consumption.High,EngineType.Diesel,80,60),
                new FuelCar("Audi","A3",3,205,Consumption.Medium,EngineType.Petrol,55,38),
                new FuelCar("Opel","Astra",3,190,Consumption.Economic,EngineType.Diesel,65,42),
            };


        }

    }
}
