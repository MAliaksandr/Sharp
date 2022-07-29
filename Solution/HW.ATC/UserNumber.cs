using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.ATC
{
    // сам номер
    // тариф
    // дата подключения тарифа
    // 
    internal class UserNumber:IAddLogInfoble
    {
        private string _chengeTariffDate;
        public Int32 Number { get; set; }
        public Tariff Tariff { get; set; }

        public void AddLogInfo(string info)
        {
            if (info is null)
            {
                throw new ArgumentNullException("Dont't used null value");
            }

            try
            {
                using (var sw = new StreamWriter(OutPutFilePath, true))
                {
                    sw.WriteLine($"{info}");
                    sw.WriteLine($"{word.ToString()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cann't write sentences into file {ex.ToString}");
            }
        }

        //public bool Change
        //{
        //    get;
        //    set
        //    {
        //        // проверим не в этом ли месяце был  если в этом - ругнемся
        //        if (true)
        //        {
        //            Console.WriteLine("You cann't change tariff because this tariff was changed in this month");
        //        }
        //    }

        //}
    }
}
