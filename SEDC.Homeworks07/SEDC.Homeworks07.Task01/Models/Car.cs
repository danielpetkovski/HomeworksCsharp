using SEDC.Homeworks07.Task01.Enums;
using SEDC.Homeworks07.Task01.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Homeworks07.Task01.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumption { get; set; }
        public EngineType EngineType { get; set; }

        public Car(string brand,string model,int doors, int topSpeed, Consumption consumption, EngineType engine)
        {
            Id = IdGenerator.GenerateId();
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = topSpeed;
            Consumption = consumption;
            EngineType = engine;
        }

        public string PrintInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Doors: {Doors}, Top Speed: {TopSpeed}, " +
                $"Consumption: {Consumption}, Engine Type: {EngineType}";
        }

    }

    
}
