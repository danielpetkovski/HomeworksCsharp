using System;

namespace SEDC.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 6:
              Write a program that will find out the sum of all numbers that divide 5 in the range 1-N
              (N is input from keyboard).
              */

            int sum = 0;
            while (true)
            {
                Console.WriteLine("Please input number greater than 1: ");

                int inputNumber;

                bool isValid = int.TryParse(Console.ReadLine(), out inputNumber);

                if (isValid && (inputNumber > 1))
                {
                    for (int i = 0; i <= inputNumber; i++)
                    {

                        if (i % 5 == 0)
                        {
                            sum += i;
                        }
                    }
                    Console.WriteLine("The sum of numbers that are divisible by 5 in range from 1-" + inputNumber + " is: " + sum);
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid input");
                }

            }




            Console.ReadLine();
        }
    }
}

