using System;

namespace SEDC.Taskz11
{
    class Program
    {
        /*Task 11:
Write a program that will print out all two-digit numbers, which have the first digit greater than the second digit.*/
        static void Main(string[] args)
        {
           
            for (int i = 10; i < 100; i++)
            {
                int firstDigit = i / 10;
                int lastDigit = i % 10;

                if (firstDigit>lastDigit)
                {
                    Console.WriteLine(i);
                }


            }

            Console.ReadLine();
            
        }
    }
}
