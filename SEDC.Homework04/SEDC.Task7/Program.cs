using System;

namespace SEDC.Task7
{
    class Program
    {

        /*Task 7:
Create a function that calculates the result of raising an integer to another integer(eg 5 raised to 3 = 53 = 5 × 5 × 5 = 125).*/

        static void Main(string[] args)
        {
            Console.WriteLine("Please insert number and its power:");

            Console.WriteLine(Riser(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));

            Console.ReadLine();
        }

        public static double Riser(double number, double power)
        {
            double result = Math.Pow(number, power);

            return result;
        }
    }
}
