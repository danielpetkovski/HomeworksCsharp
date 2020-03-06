using System;

namespace SEDC.Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Real Calculator");
            Console.WriteLine("Enter the first number:");
            int firstNumber;

            bool isValidFirst = int.TryParse(Console.ReadLine(), out firstNumber);

            Console.WriteLine("Enter the second number:");
            int secondNumber;

            bool isValidSecond = int.TryParse(Console.ReadLine(), out secondNumber);

            Console.WriteLine("Enter operation:");

            //char operation = Console.ReadKey().KeyChar;

            char operation = Console.ReadLine()[0];
            
            if(isValidFirst && isValidSecond)
            {
                switch (operation)
                {
                    case '+':
                        Console.WriteLine(firstNumber + secondNumber);
                            break;
                    case '-':
                        Console.WriteLine(firstNumber - secondNumber);
                        break;
                    case '*':
                        Console.WriteLine(firstNumber * secondNumber);
                        break;
                    case '/':
                        Console.WriteLine(firstNumber / secondNumber);
                        break;
                    default:
                        Console.WriteLine("Enter valid operator!");
                        break;
                }
            }else
            {
                Console.WriteLine("Enter valid numbers!");
            }


            Console.ReadLine();




        }
    }
}
