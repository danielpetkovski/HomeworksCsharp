using System;

namespace SEDC.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = new string[4] { "a", "b", "c", "d" };

            Array.Reverse(stringArray);

                Console.WriteLine($"{stringArray[0]} {stringArray[1]} {stringArray[2]} {stringArray[3]}");
           


            Console.ReadLine();
        }
    }
}
