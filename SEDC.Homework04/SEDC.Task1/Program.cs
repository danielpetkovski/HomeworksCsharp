using System;

namespace SEDC.Task1
{
    class Program
    {
        /*Task 1:
Create a function to say whether a string is symmetric(a palindrome). For example, "RADAR" is a palindrome.*/
        static void Main(string[] args)
        {
            IsPalindrome();
            Console.ReadLine();
        }


        public static void IsPalindrome()
        {
            Console.WriteLine("Enter text:");
            string pal = Console.ReadLine();
            string reverse = String.Empty;

            for (int i = pal.Length - 1; i >= 0; i--)
            {
                reverse += pal[i].ToString();
            }
            if(reverse == pal)
            {
                Console.WriteLine($"{pal} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{pal} is not a palindrome");

            }
        }
    }
}
