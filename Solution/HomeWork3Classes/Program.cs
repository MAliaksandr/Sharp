using System;

namespace HomeWork3Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // work with class Money

            var byr = new Money(12.01);

            Console.WriteLine($"rub = {byr.GetRub}  & cents={byr.GetKop}");


            // work with Fractions

            var element_1 = new Fractions();
            var element_2 = new Fractions();

            var firstValue = element_1.GetFractions(12.179);

            var secondValue = element_2.GetFractions(12.179);

            Console.WriteLine($"elem1 = {firstValue} \t & elem2 = {secondValue}");

            var wholePart = element_1.WholePart;

            Console.WriteLine($"WholePart  = {wholePart} and FracPart ={element_1.FracPart}");

            Fractions.ReturnSum(firstValue, secondValue);

            Fractions.ReturnSubtraction(firstValue, secondValue);

            Fractions.ReturnMultiplic(firstValue, secondValue);

            Fractions.ReturnСompare(firstValue, secondValue);



        }
    }
}