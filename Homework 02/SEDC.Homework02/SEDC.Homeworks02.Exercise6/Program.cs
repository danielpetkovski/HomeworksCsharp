using System;

namespace SEDC.Homeworks02.Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 7");

            Console.WriteLine("Please enter a number from 1-3");

            int input = Console.ReadLine()[0];
            /*bool isInputValid = int.TryParse(Console.ReadLine(), out input);*/

            switch (input)
            {
                case '1':
                    Console.WriteLine("You got a new car!");
                    break;
                case '2':
                    Console.WriteLine("You got a new plane!");
                    break;
                case '3':
                    Console.WriteLine("You got a new bike!");
                    break;
                default:
                    Console.WriteLine("Please enter valid number!");
                    break;
            }

            Console.ReadLine();


        }
    }
}
