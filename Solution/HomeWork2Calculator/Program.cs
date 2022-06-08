using System;

namespace HomeWork2Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, select one of the operation or exit for exit from calculator:");

            Console.WriteLine($"Factorial is {ReturnFactotial(ReturnIntValue())}");


          // var s = Return2RandomValues();





            //    ReturnSum();


            // var res = EnterSymbolFromKeyBoard();

            //  var  res = GetSmValues();
            //Console.WriteLine($"v1 = : {res}");

            //  Console.WriteLine($"v1 = : {res[]}");       
        }

        static bool SelectMathType()
        {
            Console.WriteLine("\nYou must enter number");
            Console.WriteLine("1 - \"+\" ");
            Console.WriteLine("2 - \"-\" ");
            Console.WriteLine("3 - \"*\" ");
            Console.WriteLine("4 - \"/\" ");
            Console.WriteLine("5 - \"^\" ");
            Console.WriteLine("6 - \"!\" ");

            var resEnterConsole = Console.ReadLine() != ""
                                ? Console.ReadLine()
                                : "Enter something..";

            if (resEnterConsole.ToUpperInvariant() == "EXIT")
            {
                return false;   
            }
            return true;


     
        }
        static int ReturnSum(int firVal, int secVal)
        {

            int res = firVal + secVal;

            return res;

        }

        static int ReturnSubtraction(int firVal, int secVal)
        {
            
            int res = firVal - secVal;
            
            return res;

        }

        static int ReturnMultiplic(int firVal, int secVal)


        {
            var res = firVal * secVal;
            return res;
        }

        static double RetuгnDivision(int firVal, int secVal)
        {
            double res = firVal / secVal;
            return res;
        }


        static long ReturnExponent(int firVal, int secVal)
        {
            long res = (long)Math.Pow(firVal, secVal);
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

        static int ReturnIntValue()
        {
            Random rand = new Random();

            var res = rand.Next(1, 20);

            Console.WriteLine($"IntValue = {res}");
           
            return res;

        }
        static int[] Return2RandomValues() {
                   

            Random rand = new Random();

            var FirstValue = rand.Next(-100, 100);
            var SecondValue = rand.Next(-100, 100);


            int[] arr = { FirstValue, SecondValue };

            Console.WriteLine($"FirstValue = {FirstValue} and SecondValue = {SecondValue}");
            return arr;
        }

        static bool EnterSymbolFromKeyBoard()
        {
        
            Console.WriteLine("Do you want enter your sumbol \"key press Y\"?");
           
            string str = Console.ReadLine()?.ToUpperInvariant() ?? "null_symb";

            bool res = false;

            if (str == "Y")
            {
                res = true;
            };

            return res;


        }

     }
}