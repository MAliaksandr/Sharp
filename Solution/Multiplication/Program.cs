using System;

namespace Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application return multiplication table by number, whitch you enter");
            string stringValue;
            do
            {
                int number = 0;
                Console.WriteLine("Please, enter number or 'EXIT' for exit application!");
                stringValue = Console.ReadLine();

                bool isInt = int.TryParse(stringValue, out number);

                if (isInt)
                {
                    int result = 0;
                    for (int i = 0; i <= 10; i++)
                    {
                        result = number * i;
                        Console.WriteLine($"{number} X {i} = {result}");
                    }
                }
                else
                {
                    Console.WriteLine("Please, enter a number");
                }

            } while (stringValue != "EXIT");
        }
    }
}