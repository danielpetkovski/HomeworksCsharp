using System;

namespace SEDC.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task 3:
             Write a program, which will be calculating the product of the digits of an input number.
             */
            Console.WriteLine("Enter number: ");
            
            while (true)
            {
                int num = 0;
                bool isValid = int.TryParse(Console.ReadLine(), out num);
                int sum = 0;
                if (isValid)
                {
                    for (int n = num; n > 0; sum += n % 10, n /= 10)
                    {
                        ;
                    }
                    Console.WriteLine("The sum of the digits is " + sum);
                    break;
                }
                Console.WriteLine("Invalid number!");
            }
            
            Console.ReadLine();

        }
    }
}
