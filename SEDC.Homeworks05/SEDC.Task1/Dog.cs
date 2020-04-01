using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Task1
{
    public class Dog
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public void Choose (string text)
        {

            //maybe switch
            if (text == "1")
            {
                Eat();
            }
            else if (text == "2")
            {
                Play();
            }
            else if (text == "3")
            {
                ChaseTail();
            }
            else
            {
                Console.WriteLine("Invalid action input");
            }
        }
        public void Eat ()
        {
            Console.WriteLine($"The dog {Name} is now eating");
        }
        public void Play()
        {
            Console.WriteLine($"The dog {Name} is now playing");
        }
        public void ChaseTail ()
        {
            Console.WriteLine($"The dog {Name} is now chasing his tail.");
        }

    }
}
