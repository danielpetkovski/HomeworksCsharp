using System;

namespace SEDC.Task4
{
    class Program
    {
        /*Task 4:
Create a function to read a sentence from input and replace lowercase characters by uppercase and vice-versa.*/

            //Dali kodov tuka vazi i za 5tata vezba?

     /*   Task 5:
Create a function to check whether a character is an alphabet or not and if so go to check for the case.*/
        static void Main(string[] args)
        {
            Console.WriteLine(CaseReplacer(Console.ReadLine()));
            Console.ReadLine();
        }


        public static string CaseReplacer(string input)
        {
            string replacedString = String.Empty;
            foreach (char n in input)
            {

                if (char.IsLetter(n) && char.IsUpper(n))
                {
                   replacedString += char.ToLower(n);
                }
                else if (char.IsLetter(n) && char.IsLower(n))
                {
                   replacedString += char.ToUpper(n);
                }
            }
            return replacedString;
        }
    }
}
