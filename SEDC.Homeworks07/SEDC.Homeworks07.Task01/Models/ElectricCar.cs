using SEDC.Homeworks07.Task01.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homeworks07.Task01.Models
{
    public class ElectricCar : Car
    {
        public double BatteryCapacity { get; set; }
        public double BatteryUsage { get; set; }

        public ElectricCar(string brand, string model, int doors, int topSpeed, Consumption consumption, double batteryCapacity, double batteryUsage)
            : base(brand, model, doors, topSpeed, consumption, EngineType.Electric)
        {
            EngineType = EngineType.Electric;
            BatteryCapacity = batteryCapacity;
            BatteryUsage = batteryUsage;
        }

        public string Drive(double distance)
        {

            double usedEnergy = 0;
            double usedPercentage = 0;
            if (Consumption == Consumption.Economic)
            {
                usedEnergy = distance * (1 / 10);
                usedPercentage = usedEnergy / BatteryCapacity * 100;

                if ((100-BatteryUsage) < usedPercentage)
                {
                    return $"You do not have enough battery for that trip";
                }
                BatteryUsage += usedPercentage;
            }
            if (Consumption == Consumption.Medium)
            {
                usedEnergy = distance * (2 / 10);
                usedPercentage = usedEnergy / BatteryCapacity * 100;
                if ((100 - BatteryUsage) < usedPercentage)
                {
                    return $"You do not have enough battery for that trip";
                }
                BatteryUsage += usedPercentage;
            }
            if (Consumption == Consumption.High)
            {
                usedEnergy = distance * (3 / 10);
                usedPercentage = usedEnergy / BatteryCapacity * 100;

                if ((100 - BatteryUsage) < usedPercentage)
                {
                    return $"You do not have enough battery for that trip";
                }
                BatteryUsage += usedPercentage;
            }
            return $"You have used {usedEnergy} percent of battery charge";
        }

        public string Recharge(double minutes)
        {
            if((100 - BatteryUsage) == 100)
            {
                return $"Your battery is full!";
            }

            double batteryRecharged = minutes * 0.1;
            double minutesToFull = BatteryUsage / 0.1;
            if (minutesToFull < minutes)
            {
                BatteryUsage -= minutesToFull * 0.1;

                return $"Your battery is full and has been charged in {minutesToFull} minutes, cannot charge longer";
            }

            BatteryUsage -= batteryRecharged;
            return $"You have recharged your car for {batteryRecharged} and your current charge is {100-BatteryUsage}";
        }

    }
}
