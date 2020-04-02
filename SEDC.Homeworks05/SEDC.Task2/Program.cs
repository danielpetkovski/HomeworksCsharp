using System;

namespace SEDC.Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Drivers
            
            Driver[] person = new Driver[4];
            person[0] = new Driver();
            person[0].Name = "Bob";
            person[0].Skill = 4;

            person[1] = new Driver();
            person[1].Name = "Greg";
            person[1].Skill = 3;

            person[2] = new Driver();
            person[2].Name = "Jill";
            person[2].Skill = 4;

            person[3] = new Driver();
            person[3].Name = "Anne";
            person[3].Skill = 2;

            #endregion

            #region Cars
            Car[] cars = new Car[4];

            cars[0] = new Car();
            cars[0].Model = "Hyundai";
            cars[0].Speed = 2;


            cars[1] = new Car();
            cars[1].Model = "Mazda";
            cars[1].Speed = 3;

            cars[2] = new Car();
            cars[2].Model = "Ferrari";
            cars[2].Speed = 5;

            cars[3] = new Car();
            cars[3].Model = "Porsche";
            cars[3].Speed = 4;

            #endregion


            Console.WriteLine("Choose car no.1: \n {0} \n {1} \n {2} \n {3}", cars[0].Model, cars[1].Model, cars[2].Model, cars[3].Model);

            string car1Input = Console.ReadLine();

            Car selectedCar1 = new Car();
            foreach (var item in cars)
            {
                if (item.Model.ToLower() == car1Input.ToLower())
                {

                    selectedCar1 = item;

                    int indexToRemove = Array.IndexOf(cars, item);

                    for (int i = indexToRemove; i < cars.Length - 1; i++)
                    {
                        // moving elements downwards, to fill the gap at [index]
                        cars[i] = cars[i + 1];
                    }
                    // finally, let's decrement Array's size by one
                    Array.Resize(ref cars, cars.Length - 1);
                }
            }

            Console.WriteLine("Choose driver no.1: \n {0 } \n {1} \n {2} \n {3}",
                              person[0].Name,
                              person[1].Name,
                              person[2].Name,
                              person[3].Name);

            string driver1Input = Console.ReadLine();

            Driver drv = new Driver();
            foreach (var item in person)
            {
                if (item.Name.ToLower() == driver1Input.ToLower())
                {
                    drv = item;

                    int indexToRemove = Array.IndexOf(person, item);

                    for (int i = indexToRemove; i < person.Length - 1; i++)
                    {
                        // moving elements downwards, to fill the gap at [index]
                        person[i] = person[i + 1];
                    }
                    // finally, let's decrement Array's size by one
                    Array.Resize(ref person, person.Length - 1);
                }
            }

            selectedCar1.Driver = drv;

            Console.WriteLine("Choose car no.2: ");
            foreach (var item in cars)
            {
                Console.WriteLine(item.Model);
            }

            string car2Input = Console.ReadLine();


            Console.WriteLine("Choose driver no.2:");
            foreach (var item in person)
            {
                Console.WriteLine(item.Name);
            }

            string driver2Input = Console.ReadLine();

            Car selectedCar2 = new Car();
            foreach (var item in cars)
            {
                if (item.Model.ToLower() == car2Input.ToLower())
                {
                    selectedCar2 = item;

                }
            }

            Driver drv2 = new Driver();
            foreach (var item in person)
            {
                if (item.Name.ToLower() == driver2Input.ToLower())
                {
                    drv2 = item;
                }
            }

            selectedCar2.Driver = drv2;

            RaceCars(selectedCar1, selectedCar2);

            Console.ReadLine();
        }


        public static void RaceCars(Car car1, Car car2)
        {            
            if (car1.CalculateSpeed() > car2.CalculateSpeed())
            {
               Console.WriteLine("Car no.1 was faster");
            }
            else if (car1.CalculateSpeed() < car2.CalculateSpeed())
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