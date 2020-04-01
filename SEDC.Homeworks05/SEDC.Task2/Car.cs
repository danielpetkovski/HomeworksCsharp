using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Task2
{
   public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public string Driver { get; set; }

        /*public Driver DriverObj;*/
        public int CalculateSpeed(Driver driver)
        {
            int res = driver.Skill * Speed;

            return res;
        }
    }
}
