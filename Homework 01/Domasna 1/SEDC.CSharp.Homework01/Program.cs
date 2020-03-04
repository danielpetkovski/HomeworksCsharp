using System;
using System.Threading;
namespace SEDC.CSharp.Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traffic Light....\n");
            Thread.Sleep(2000);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine("Red Light - STOP!\n");
            Thread.Sleep(2000);

            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Yellow Light - Prepare.\n");
            Thread.Sleep(2000);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Green Light - Go!\n");

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
