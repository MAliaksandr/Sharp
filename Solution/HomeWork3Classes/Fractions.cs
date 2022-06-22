using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3Classes
{
    public class Fractions
    {
        private long wholePart;
        private ushort fracPart;

        public long WholePart
        {
            get { return wholePart; }
        }

        public ushort FracPart
        {
            get { return fracPart; }
        }

        public Fractions()
        {
            wholePart = 0;
            fracPart = 0;
        }

        public double GetFractions(double dblValue)
        {
            var wholeValue = (int)dblValue;

            var dblValueToStr = dblValue.ToString();

            string stringValue = dblValueToStr.Substring(dblValueToStr.IndexOf(',') + 1);

            ushort strFracToInt = Convert.ToUInt16(stringValue);

            this.wholePart = wholeValue;

            this.fracPart = strFracToInt;

            return dblValue;
       }

        public static void ReturnSum(double firstValue, double secondValue)
        {
            var result = firstValue + secondValue;

            Console.WriteLine($"Sum = {result}");
        }

        public static void ReturnSubtraction(double firstValue, double secondValue)
        {
            double result = firstValue - secondValue;

            Console.WriteLine($"Result of Subtraction = {result}");
        }

        public static void ReturnMultiplic(double firstValue, double secondValue)
        {
            var result = firstValue * secondValue;

            Console.WriteLine($"Result of multiplication = {result}");
        }

        public static void ReturnСompare(double firstValue, double secondValue)
        {
            if (firstValue > secondValue)
            {
                Console.WriteLine($"firstValue: {firstValue} > secondValue:{secondValue}");
            }
            else if (firstValue < secondValue)
            {
                Console.WriteLine($"secondValue: {firstValue} > firstValue:{secondValue}");
            }
            else
            {
                Console.WriteLine($"firstValue = secondValue = {firstValue} ");
            }
        }

    }
}

