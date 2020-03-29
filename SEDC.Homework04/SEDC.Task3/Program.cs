using System;

namespace SEDC.Task3
{
    class Program
    {
       /* Task 3:
Create a two function that calculates the amount of numeric digits and vowels(samoglaski) that a text string contains.
            It will accept one parameter parameter: the string that we want to search,

Function 1 should return the number of digits,
Function 2 should return the number of vowels.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Please input mixed text:");
           
           string text =  Console.ReadLine();

            Console.WriteLine($"The number of digits in the input is:{DigitCounter(text)}");

            Console.WriteLine($"The number of vowels in the input is:{VowelsCounter(text)}");

            Console.ReadLine();
        }


        public static int DigitCounter(string input)
        {
            int digitsCount = 0;
            foreach (char n in input)
            {
                if (Char.IsDigit(n))
                {
                    digitsCount++;
                }
            }
            return digitsCount;
        }


        public static int VowelsCounter(string input)
        {
            int vowelsCount = 0;
            foreach (char n in input)
                if(n == 'a' || n == 'e' || n == 'i' || n == 'o' || n == 'u')
                {
                    vowelsCount++;
                }
            return vowelsCount; 
        }
    }
}
