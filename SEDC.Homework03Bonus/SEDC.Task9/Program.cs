using System;

namespace SEDC.Task9
{
    class Program
    {
/*        Task 9:
Write a program that will find all numbers in between 1 and 1000, that divide the sum composed of their digits.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert a number from 1-1000:");

            int num = 0;
            bool isValid = int.TryParse(Console.ReadLine(), out num);
            int sum = 0;
            int[] arrOfDivisible = new int[0];

            if (isValid)
            {
                for (int n = num; n > 0; sum += n % 10, n /= 10)
                {
                    ;
                }
                for (int i = 1; i <= 1000; i++)
                {
                    if (i % sum == 0)
                    {
                        Array.Resize(ref arrOfDivisible, arrOfDivisible.Length + 1);
                        int lastIndex = arrOfDivisible.Length -1;
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
