using System;

namespace SEDC.Homework02.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average Number");

            Console.WriteLine("Enter the first number:");
            double firstNumber;

            bool isValidFirst = double.TryParse(Console.ReadLine(), out firstNumber);

            Console.WriteLine("Enter the second number:");
            double secondNumber;

            bool isValidSecond = double.TryParse(Console.ReadLine(), out secondNumber);

            Console.WriteLine("Enter the third number:");
            double thirdNumber;

            bool isValidThird = double.TryParse(Console.ReadLine(), out thirdNumber);

            Console.WriteLine("Enter the fourth number:");
            double fourthNumber;

            bool isValidFourth = double.TryParse(Console.ReadLine(), out fourthNumber);



            if(isValidFirst && isValidSecond && isValidThird && isValidFourth)
            {
                double average = (firstNumber + secondNumber + thirdNumber + fourthNumber)/4;
                Console.WriteLine($"The average of { firstNumber},{secondNumber},{thirdNumber},{fourthNumber} is {average}");
            }
            else
            {
                Console.WriteLine("Enter valid numbers!");
            }

            Console.ReadLine();
        }


    }
}
