using System;

namespace SEDC.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 1:
            Write a program that will print out all numbers from the range
            1 - N(N is input from keyboard, N > 2) that divide with 3.
            */
              

            while (true)
            {
                Console.WriteLine("Please input number greater than 2: ");

                int inputNumber;

                bool isValid = int.TryParse(Console.ReadLine(), out inputNumber);

                if (isValid && (inputNumber > 2))
                {
                    for (int i = 3; i <= inputNumber; i += 3)
                    {
                        //if(inputNumber % 3 == 0) - mesto i++   i+=3
                        Console.WriteLine("The numbers that are divisible by 2 and 3 are:" + i);
                    }
                    break;
                }
                Console.WriteLine("Invalid input");

            }





            Console.ReadLine();
        }
    }
}
