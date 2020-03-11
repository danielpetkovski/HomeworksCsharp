using System;

namespace SEDC.Homework03.Task1
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

            Console.WriteLine("Insert sixth number: ");
            int sixthElement;
            bool isValid6 = int.TryParse(Console.ReadLine(), out sixthElement);

            int[] array = new int[6] { firstElement, secondElement, thirdElement, fourthElement, fifthElement, sixthElement };

            int sum = 0;

            foreach (var item in array)
            {
                if(item % 2 == 0)
                {
                    sum += item;
                }
            }


            Console.WriteLine("The sum of the inserted even numbers is: " + sum);

            Console.ReadLine();
        }
    }
}
