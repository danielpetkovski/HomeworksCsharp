using SEDC.Homeworks07.Task01.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homeworks07.Task01.Models
{
    public class FuelCar : Car
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }

        public FuelCar(string brand, string model, int doors, int topSpeed, Consumption consumption, EngineType engine, double fuelCapacity, double currentFuel)
           : base(brand, model, doors, topSpeed, consumption, engine)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
        }

        public string Drive(int distance)
        {

            double usedFuel;
            if (Consumption == Consumption.Economic)
            {
                usedFuel = distance * (1 / 10);
                if (CurrentFuel < usedFuel)
                {
                    return $"You do not have enough battery for that trip";
                }
                CurrentFuel -= usedFuel;
                return $"You have used {usedFuel} liters of fuel";
            }
            if (Consumption == Consumption.Medium)
            {
                usedFuel = distance * (2 / 10);
                if (CurrentFuel < usedFuel)
                {
                    return $"You do not have enough battery for that trip";
                }
                CurrentFuel -= usedFuel;
                return $"You have used {usedFuel} liters of fuel";
            }
            if (Consumption == Consumption.High)
            {
                usedFuel = distance * (3 / 10);
                if (CurrentFuel < usedFuel)
                {
                    return $"You do not have enough battery for that trip";
                }
                CurrentFuel -= usedFuel;
                return $"You have used {usedFuel} liters of fuel";
            }
            return $"You have entered wrong consumption";
        }


        public string Refuel(double fuel)
        {
            if (CurrentFuel == FuelCapacity)
            {
                return $"Your tank is full!";
            }

            double missingFuel = FuelCapacity - CurrentFuel;
            if (missingFuel < fuel)
            {
                CurrentFuel += missingFuel;

                return $"Your tank is full now and has been refueled for {missingFuel} liters, you have {fuel - missingFuel} liters excess fuel";
            }

            CurrentFuel += fuel;
            return $"You have refueled your tank for {fuel} liters and your current fuel level is {CurrentFuel}";
        }


    }

}
