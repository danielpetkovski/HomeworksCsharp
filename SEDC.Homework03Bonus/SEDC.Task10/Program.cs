using System;

namespace SEDC.Task10
{
    class Program
    {

        //Task 10.
        //Write a program that will find out all numbers in the range[1 : 1000] that divide the product composed of their digits.
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number from 1-1000:");

            int num = 0;
            bool isValid = int.TryParse(Console.ReadLine(), out num);
            int product = 1;
            int[] arrOfDivisible = new int[0];

            if (isValid)
            {
                while (num != 0)
                {
                    product = product * (num % 10);
                    num = num / 10;
                }
                for (int i = 1; i <= 1000; i++)
                {
                    if (i % product == 0)
                    {
                        Array.Resize(ref arrOfDivisible, arrOfDivisible.Length + 1);
                        int lastIndex = arrOfDivisible.Length - 1;
                        arrOfDivisible[lastIndex] = i;
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            foreach (int item in arrOfDivisible)
            {
                Console.WriteLine($"Item: {item}");
            }



            Console.ReadLine();
        }
    }
    }
