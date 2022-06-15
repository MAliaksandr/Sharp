using System;

namespace TempCode.PaintTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add a height of the triangle");

            int defValue = 1;

            var isInt = int.TryParse(Console.ReadLine(), out defValue);

            if (isInt)
            {
                TrianglePaint(defValue);
                TriangleRotetePaint(defValue);
                TriangleRotateMirrorPaint(defValue);
                TriangleMirrorPaint(defValue);             
            }
            else
                Console.WriteLine("Please, enter a number");
        }

        static void TrianglePaint(int defValue)
        {
            for (int i = 0; i < defValue; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void TriangleRotetePaint(int defValue)
        {
            for (int i = 0; i <=defValue; i++)
            {
                for(int j = defValue; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        static void TriangleMirrorPaint(int defValue)
        {
            for (int i = 0; i < defValue; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                
                for (var k = defValue; k > i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void TriangleRotateMirrorPaint(int defValue)
        {
            for (int i = 0; i <=defValue; i++)
            {
                for (var j = defValue; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (var k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}