using System;

namespace HomeWork2Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I'm a calculator");

            var result = true;

            while (SelectMathType(ref result))
            {
            
                SelectMathType(ref result);
            }
                          
          
        }

        static bool SelectMathType(ref bool result)
        {
            if (!result)
            {
                Console.WriteLine("Good Bye, my dear friend!");
                return false;
            }

           

            Console.WriteLine("\nPlese select number of Math operation:");
            Console.WriteLine("1 - \"+\" ");
            Console.WriteLine("2 - \"-\" ");
            Console.WriteLine("3 - \"*\" ");
            Console.WriteLine("4 - \"/\" ");
            Console.WriteLine("5 - \"^\" ");
            Console.WriteLine("6 - \"!\" ");
            Console.WriteLine("If You want to EXIT - select 9\" ");


            var defaultValue = -1;
            
            var resEnterConsole = int.TryParse(Console.ReadLine(), out defaultValue);

            if (resEnterConsole)
            {
                // 
                var firstValue = 0;
                var secValue = 0;


                switch (defaultValue)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        if (!EnterSymbolFromKeyBoard())
                        {
                            var rand = Return2RandomValues();
                            firstValue = rand[0];
                            secValue = rand[1];
                        }
                        else
                        {
                            firstValue = GetIntValueFromConcole();
                            secValue = GetIntValueFromConcole();
                        }
                        break;
                    default:
                        break;

                }


                switch (defaultValue)
                {
                    case 1:
                        ReturnSum(firstValue, secValue);
                        break;
                    case 2:
                        ReturnSubtraction(firstValue, secValue);
                        break;
                    case 3:
                        ReturnMultiplic(firstValue, secValue);
                        break;
                    case 4:
                        RetuгnDivision(firstValue, secValue);
                        break;
                    case 5:
                        ReturnExponent(firstValue, secValue);
                        break;
                    case 6:
                        RetResultFactioal(ReturnIntValue());
                        break;
                
                    case 9:
                        result = false;
                        return result;
                       // exit from switch & function

                    default:
                        Console.WriteLine("Please, enter correct number of operation!");
                        break;
                }
                  
            }
            else
            {
                Console.WriteLine("Enter correct number");
            }

            ClearConsole();

            return result;
        }

        static void ClearConsole()
        {
            Console.WriteLine("\nDo you want to clear console? Y/N?");
            ConsoleKey consoleKey = Console.ReadKey().Key;

            switch (consoleKey)
            {
                case ConsoleKey.Y:
                    Console.Clear();
                    break;
            }
        }

        static int ReturnSum(int firVal, int secVal)
        {

            int res = firVal + secVal;
            Console.WriteLine($"\n{firVal} + {secVal} = {res}");
            return res;

        }

        static int ReturnSubtraction(int firVal, int secVal)
        {
            
            int res = firVal - secVal;
            Console.WriteLine($"\n{firVal} - {secVal} = {res}");
            return res;

        }

        static int ReturnMultiplic(int firVal, int secVal)
        {

            var res = firVal * secVal;
            Console.WriteLine($"\n {firVal} * {secVal} = {res}");
            return res;

        }

        static double RetuгnDivision(int firVal, int secVal)
        {
            if (secVal != 0)
            {
                double res = (double)firVal / secVal;
                Console.WriteLine($"\n {firVal} / {secVal} = {res}");
                return res;
            }

            Console.WriteLine("Division by zerro is incorrect!");
            return 0;
        }
       
        static long ReturnExponent(int firVal, int secVal)
        {
            long res = (long)Math.Pow(firVal, secVal);

            Console.WriteLine($"\n {firVal} ^ {secVal} = {res}");
            return res;
        }
       
        static long ReturnFactotial(int value)
        {
            if (value == 0)
            {
                return 1;
            }
            else
                return value * ReturnFactotial(value - 1);

        }

        static void RetResultFactioal(int value)
        {
            var result = ReturnFactotial(value);

            Console.WriteLine($"\nResult !n, where n={value} is {result}");

        }
        
        static int ReturnIntValue()
        {
            Random rand = new Random();

            var res = rand.Next(1, 20);

            Console.WriteLine($"\nIntValue = {res}");
           
            return res;

        }

        static int[] Return2RandomValues() {
                   

            Random rand = new Random();

            var FirstValue = rand.Next(-100, 100);
            var SecondValue = rand.Next(-100, 100);


            int[] arr = { FirstValue, SecondValue };

            Console.WriteLine($"\nFirstValue = {FirstValue} and SecondValue = {SecondValue}");
            return arr;
        }

        static bool EnterSymbolFromKeyBoard()
        {
            var result = false;

            Console.WriteLine("\nDo you want enter values from keyboard? PressKey \"Y\"");
           
            ConsoleKey consoleKey = Console.ReadKey().Key;

            switch (consoleKey)
            {
                case ConsoleKey.Y:
                    result = true;
                    break;
            }
            return result;
        }

        static int strValueIsInt(string str)
        {
            var defValue = -1;
            var isInt = int.TryParse(str, out defValue);
            if (!isInt)
            {
                Console.WriteLine("You must enter number type INTEGER");
            }
            return defValue;

        }
        static bool strValueIsDouble(string str)
        {
            var defValue = 0.0;
            var isDouble = double.TryParse(str, out defValue);
            if (isDouble)
            {
                return true;
            }
            return false;
        }

        static int GetIntValueFromConcole()
        {
            bool isInt;
            var defaultValue = -1;
            Console.WriteLine("\nEnter some value");

            do
            {
                var str = Console.ReadLine();

                isInt = int.TryParse(str, out defaultValue);

                if (!isInt)
                {
                    Console.WriteLine("I'm waiting number of INTEGER");
                }

            } while (!isInt);

            Console.WriteLine($"value = {defaultValue}");

            return defaultValue;




        }
    }
}