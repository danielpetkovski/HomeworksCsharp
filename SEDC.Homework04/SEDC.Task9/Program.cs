using System;

namespace SEDC.Task8
{
    class Program
    {

        /*Task 8: Bonus
    Make a method called AgeCalculator
    The method will have one input parameter, your birthday date
    The method should return your age
    Show the age of a user after he inputs a date*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth date (as mm/dd/yyyy):");

            Console.WriteLine(GetAge(DateTime.Parse(Console.ReadLine())));

            Console.ReadLine();
        }

        public static int GetAge(DateTime dateOfBirth)
        {
            DateTime today = DateTime.Today;
          
            var age = today.Year - dateOfBirth.Year;
            
            if (dateOfBirth.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}
