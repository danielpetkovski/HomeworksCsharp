using System;

namespace SEDC.Task1
{
    class Program
    {
        static void Main(string[] args)
        {

          /*  Task 1
                Create a class Dog
                Add properties: Name, race, color
                The dog needs to have:
                Eat method that returns message: The dog is now eating
                Play method returning a message : The dog is now playing
                ChaseTail method that returns a message: Dog is now chasing its tail.
                The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above.*/
            Console.WriteLine("Please enter name,race and color:");


            Dog dog = new Dog()
            {
                
                Name = Console.ReadLine(),
                Race = Console.ReadLine(),
                Color = Console.ReadLine(),
                

            };

            Console.WriteLine("Please enter action (1-3):");
            dog.Choose(Console.ReadLine());

            Console.ReadLine();
        }
    }
}
