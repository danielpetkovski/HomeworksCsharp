using System;

namespace SEDC.Homework03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert first number: ");

            int firstElement;
            bool isValid1 = int.TryParse(Console.ReadLine(), out firstElement);

            Console.WriteLine("Insert second number: ");
            int secondElement;
            bool isValid2 = int.TryParse(Console.ReadLine(), out secondElement);

            Console.WriteLine("Insert third number: ");
            int thirdElement;
            bool isValid3 = int.TryParse(Console.ReadLine(), out thirdElement);

            Console.WriteLine("Insert fourth number: ");
            int fourthElement;
            bool isValid4 = int.TryParse(Console.ReadLine(), out fourthElement);

            Console.WriteLine("Insert fifth number: ");
            int fifthElement;
            bool isValid5 = int.TryParse(Console.ReadLine(), out fifthElement);

            int sum = 0;

            int[] array = new int[5] {firstElement,secondElement,thirdElement,fourthElement,fifthElement};

            foreach (var item in array)
            {
                sum += item;
            }


            Console.WriteLine("The sum of the inserted numbers is: " + sum);
            Console.ReadLine();
        }
    }
}
