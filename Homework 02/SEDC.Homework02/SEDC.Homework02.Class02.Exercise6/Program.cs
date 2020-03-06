using System;

namespace SEDC.Homework02.Class02.Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 6");

            Console.WriteLine("Enter the first number:");
            int firstNumber;

            bool isValidFirst = int.TryParse(Console.ReadLine(), out firstNumber);


            Console.WriteLine("Enter the second number:");
            int secondNumber;

            bool isValidSecond = int.TryParse(Console.ReadLine(), out secondNumber);

            if (firstNumber > secondNumber)
            {
                if (firstNumber % 2 == 0)
                {
                    Console.WriteLine($"First Number: {firstNumber} is even and it is larger than Second number: {secondNumber}");
                }
                else
                {
                    Console.WriteLine($"First Number: {firstNumber} is odd and it is larger than Second number: {secondNumber}");
                }
            }

            else if (firstNumber < secondNumber)
            {
                if (secondNumber % 2 == 0)
                {
                    Console.WriteLine($"Second Number: {secondNumber} is even and it is larger than First number: {firstNumber}");
                }
                else
                {
                    Console.WriteLine($"Second Number: {secondNumber} is odd and it is larger than First number: {firstNumber}");
                }
            }
            else
            {
                if (firstNumber % 2 == 0)
                {
                    Console.WriteLine($"The numbers {firstNumber} and {secondNumber} are equal and even");
                }
                else
                {
                    Console.WriteLine($"The numbers {firstNumber} and {secondNumber} are equal and odd");
                }
            }


            Console.ReadLine();
        }
    }
}
