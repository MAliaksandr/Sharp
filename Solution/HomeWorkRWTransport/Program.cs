using System.Text;
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


            var tr = new Train(2, "TN-25");
            tr.GetInfo();

            var array = new IGetInfoable[]
            {
                new PassengerCar(PassengerCar.PassengerCarType.P)
                {
                    BusyPlace = 12
                },
                new PassengerCar(PassengerCar.PassengerCarType.M)
                {
                    BusyPlace = 23
                },
                new PassengerCar(PassengerCar.PassengerCarType.K)
                {
                   BusyPlace= 60
                }

            };


            var sb = new StringBuilder();

            foreach (var item in array)
            {
                sb.AppendLine(item.GetInfo());
                sb.AppendLine("------------");
            }
            Console.WriteLine(sb);


        }
    }
}