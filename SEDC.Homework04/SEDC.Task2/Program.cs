using System;
using System.Linq;

namespace SEDC.Task2
{
    class Program
    {
/*
        Task 2:
Create a function which returns the greatest value stored in an array of real numbers which is specified as parameter.*/
        static void Main(string[] args)
        {
            
            int[] array = new int[5] { 1, 5, 2, 6, 3 };
            
            Console.WriteLine(GreatestValue(array));
            Console.ReadLine();
        }

        public static string GreatestValue(int[] numbers)
        {
            int greatestNumber = numbers.Max();


            return $"{greatestNumber}";
        }
    }
}
