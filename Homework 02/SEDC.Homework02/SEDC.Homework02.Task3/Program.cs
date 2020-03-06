using System;

namespace SEDC.Homework02.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap numbers");

            Console.WriteLine("Enter the First Number:");
            int firstNumber;

            bool isValidFirst = int.TryParse(Console.ReadLine(), out firstNumber);

            Console.WriteLine("Enter the Second Number:");
            int secondNumber;

            bool isValidSecond = int.TryParse(Console.ReadLine(), out secondNumber);

            /*int thirdVar;

            if(isValidFirst && isValidSecond)
            {
                thirdVar = firstNumber;
                firstNumber = secondNumber;
                secondNumber = thirdVar;
                

                Console.WriteLine($"Swaped numbers are:{firstNumber} and {secondNumber}");
               

            }*/

            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;

            if(isValidFirst && isValidSecond)
            {
                Console.WriteLine($"The numbers swaped are: First Number = {firstNumber} and Second Number: {secondNumber}");
            }

            Console.ReadLine();
        }
    }
}
