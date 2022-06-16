using System;

namespace TempCode.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var newArray =  GetIntArray();

            PrintSumOfArrayElements(newArray);

            PrintMinElemetOfArray(newArray);
        }

        static int[] GetIntArray()
        {
            var isRes = false;
            int[] array;

            while (!isRes)
            {
                Console.WriteLine("Add a length of array");

                int arrLenght = 1;

                var isInt = int.TryParse(Console.ReadLine(), out arrLenght);

                if (isInt)
                {
                    var rand = new Random();

                    array = new int[arrLenght];


                    for (int i = 0; i < arrLenght; i++)
                    {
                        array[i] = rand.Next(-20, 20);
                    }

                    foreach (int i in array)
                    {
                        Console.Write($"{i} ");                   
                    }
                    
                    Console.WriteLine();

                    isRes  = true;
                    return array;

                }
                else
                    Console.WriteLine("Please, enter correct value!");

            }


            array = new int[0];
            return array;

        }

        static void PrintSumOfArrayElements(int[] array) 
        {
            var sumResult = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sumResult = sumResult + array[i];
            }
        
            Console.WriteLine($"\n\tSumm all elements is {sumResult}");
        }


        static void PrintMinElemetOfArray(int[] array)
        {
            var Result = array[0];

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < Result)
                {
                    Result = array[i];
                }

            }

           Console.WriteLine($"\n\tMin from all elements is: {Result}");
        }
    }

   
}