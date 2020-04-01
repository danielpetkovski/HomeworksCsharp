using System;

namespace SEDC.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose the first driver:");

            string driver1Input = Console.ReadLine();

            string car1Input = Console.ReadLine();

            string driver2Input = Console.ReadLine();

            string car2Input = Console.ReadLine();


            #region Drivers
            Driver bob = new Driver()
            {
                Name = "Bob",
                Skill = 5
            };

            Driver greg = new Driver()
            {
                Name = "Greg",
                Skill = 3
            };

            Driver jill = new Driver()
            {
                Name = "Jill",
                Skill = 4
            };

            Driver anne = new Driver()
            {
                Name = "Anne",
                Skill = 2
            };
            #endregion

            #region Cars

            Car hyundai = new Car()
            {
                Model = "Hyundai",
                Speed = 2,
            };

            Car mazda = new Car()
            {
                Model = "Mazda",
                Speed = 3,
            };

            Car ferrari = new Car()
            {
                Model = "Ferrari",
                Speed = 5,
            };

            Car porsche = new Car()
            {
                Model = "Porsche",
                Speed = 4,
            };

            #endregion
   

            RaceCars(hyundai, bob, mazda, greg);

            Console.ReadLine();
        }


        public static void RaceCars(Car car1, Driver driver1, Car car2, Driver driver2)
        {


            
            if (car1.CalculateSpeed(driver1) > car2.CalculateSpeed(driver2))
            {
               Console.WriteLine("Car no.1 was faster");
            }
            else if (car1.CalculateSpeed(driver1) < car2.CalculateSpeed(driver2))
            {
                Console.WriteLine("Car no.2 was faster");
            }
            else
            {
                Console.WriteLine("The cars finished the same");
            }
        }
    }
}