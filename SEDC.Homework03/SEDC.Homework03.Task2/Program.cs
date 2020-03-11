using System;

namespace SEDC.Homework03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert 1 or 2:");

            int inputNumber;

            bool isValid = int.TryParse(Console.ReadLine(), out inputNumber);

            string[] studentsG1 = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

            string[] studentsG2 = new string[5] { "Zvonko", "Stefan", "Marija", "Ana", "Elena" };


            if (isValid && (inputNumber == 1))
            {
                Console.WriteLine("The students in G1 are: ");
                foreach (var item in studentsG1)
                {
                    Console.WriteLine(item);
                }
            }
            if (isValid && (inputNumber == 2))
            {
                Console.WriteLine("The students in G2 are: ");
                foreach (var item in studentsG2)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Insert valid input!");
            }


            Console.ReadLine();
        }
    }
}
