using System;
using System.Linq;
namespace SEDC.Task8
{
    class Program
    {

        // Task 8
      /*  Write a program that will read two arrays from console input.Then the program has to make a 
            comparison of the arrays and determine whether they are equal or not. { 1, 2, 3, 4 } == { 1, 2, 3, 4 } { 1, 2, 3, 4 } != { 2, 1, 3, 4 }*/

        static void Main(string[] args)
        {
            int[] arrayOne = new int[4];

            int[] arrayTwo = new int[4];

            Console.WriteLine("Enter 4 digits for the first array:");

            arrayOne[0] = int.Parse(Console.ReadLine());
            arrayOne[1] = int.Parse(Console.ReadLine());
            arrayOne[2] = int.Parse(Console.ReadLine());
            arrayOne[3] = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter 4 digits for the second array:");
            arrayTwo[0] = int.Parse(Console.ReadLine());
            arrayTwo[1] = int.Parse(Console.ReadLine());
            arrayTwo[2] = int.Parse(Console.ReadLine());
            arrayTwo[3] = int.Parse(Console.ReadLine());


            

            if (arrayOne.SequenceEqual(arrayTwo))
            {
                Console.WriteLine("The arrays are equal");
            }
            else
            {
                Console.WriteLine("The arrays are not equal");
            }



            Console.ReadLine();
        }
    }
}
