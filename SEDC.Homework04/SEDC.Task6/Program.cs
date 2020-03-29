using System;

namespace SEDC.Task6
{
    class Program
    {
        /*Task 6:
Create a function to find the number of times a substring appears in a given string.*/
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter string and substring:");
            Console.WriteLine($"The number of times a substring appears in the text is:{SubCount(Console.ReadLine(), Console.ReadLine())}");
            
            //Console.WriteLine($"Please insert a subtext:");


            Console.ReadLine();
        }


        public static int SubCount (string text, string param)
        {
            int parLenght = param.Length;

            int textLength = text.Length;

            int result = 0;

            for (int i = 0; i <= textLength - parLenght; i++)
            {
                int j;
                for(j = 0; j < parLenght; j++)
                {
                    if(text[i + j] != param[j])
                    {
                        break;
                    }
                }
                if (j == parLenght)
                {
                    result++;
                    j = 0;
                }

            }
            return result;
        }
    }
}
