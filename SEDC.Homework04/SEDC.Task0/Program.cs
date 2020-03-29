using System;

namespace SEDC.Task0
{
    class Program
    {

/*        Task 0
Create a new method called Substrings
In that method enter the following string :
"Hello from SEDC Codecademy v7.0"
Ask the user to enter a number n.
Print the first n characters from that string and print the length of the new string.
Make sure that the user can only enter a number and the number should be from 1 to the number of characters in the string 
            (canâ€™t enter an integer larger than the length of the string )*/
        static void Main(string[] args)
        {
            SubStrings();
            Console.ReadLine();
        }

        public static void SubStrings ()
        {
            string msg = "Hello from SEDC Codecademy v7.0";

            int n = 0;


            Console.WriteLine($"Please enter a number from 1-{msg.Length}");
            bool isValid = int.TryParse(Console.ReadLine(), out n);

            if (isValid && n > 0 && n <= msg.Length)
            {

                string newMsg = msg.Substring(0, n);
                Console.WriteLine(newMsg);
            }
            else if(n > msg.Length)
            {
                Console.WriteLine("can't enter an integer larger than the length of the string");
            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }

           
        }
    }
}
