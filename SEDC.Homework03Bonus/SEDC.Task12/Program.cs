using System;

namespace SEDC.Task12
{
    class Program
    {
       /* Task 12:
    Write a short program that prints each number from 1 to 100 on a new line.For each number that is divided by 3 print “Fizz” instead of the number.
    For each number that is divided by 5 print “Buzz” instead of the number.
    For each number that is divided by 3 and 5 print “FizzBuzz” instead of the number.*/
        static void Main(string[] args)
        {

            for (int i = 1; i <= 100; i++)
            {
                if((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if (i % 5 == 0) 
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadLine();
        }
    }
}
