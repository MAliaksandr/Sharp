using System;

namespace TempCode.Cycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int defaultHeight = 1;

            Console.WriteLine("Add height of the triangle");

            var isInt = int.TryParse(Console.ReadLine(),out defaultHeight);

            if (isInt)
            {
                for (int i = 0; i < defaultHeight; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
            else
                Console.WriteLine("Enter a number");
            

        }
    }
}