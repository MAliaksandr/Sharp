﻿using System.Text;
namespace HomeWorkRWTransport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* описание: 
               предполагается 2 класса: СОСТАВ и ВАГОН
               -------
               СОСТАВ ГРУЗОВОЙ:
               -паровоз-тягач
               -вагоны: платформа,контейнер,цистерна,рефрежиратор,полувагон,крытый 
               
                СОСТАВ ПАССАЖИРСКИЙ:
                -паровоз-тягач
                -вагоны: СВ, купейный, плацкартный, общий, межобластной, вагон-ресторан
               
               все вагоны могут загружаться и разгружаться в общем смысле
               
               состав может: движение, стоянка, сортировка, комплект/разкомлект
             
               общие методы для состава: подсчет кол-ва вагонов
                 для товарного -  количество пустых и кол-во полных
                 для пассажирского - колчичество человек в пути
                                     для дальнего следования - вагон ресторан
            **************
            по ТЗ
            Создать пассажирский поезд. Посчитать общую численность 
            пассажиров и багажа. Провести сортировку вагонов поезда на основе уровня 
            комфортности. Найти вагоны в поезде, соответствующие заданному диапазону 
            параметров числа пассажиров.
               
             */

            //var v1 = new PassengerCar(PassengerCar.PassengerCarType.K)
            //{
            //    BusyPlace = 13
            //};

            //v1.GetInfo();


            var tr = new Train(5, "TN-25");

            Console.WriteLine(tr.GetInfo());
       
            Console.WriteLine($"count car in this tarin:{tr.countCar}"); ;

            foreach (var item in tr.trainCollectCars)
            {

            }


        }
    }
}