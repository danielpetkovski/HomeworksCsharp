using System;

namespace SEDC.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 2:
             Write a program that will print out all numbers in the range 1-N (N is input from keyboard, N>5)
             that divide 2 and 3.
             */


            while (true)
            {
                Console.WriteLine("Please input number greater than 5: ");

                int inputNumber;

                bool isValid = int.TryParse(Console.ReadLine(), out inputNumber);

                if (isValid && (inputNumber > 5))
                {
                    for (int i = 6; i <= inputNumber; i++)
                    {
                        if ((i % 3 == 0) && (i % 2 == 0))
                            Console.WriteLine("The numbers that are divisible by 2 and 3 are:" + i);
                    }
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
