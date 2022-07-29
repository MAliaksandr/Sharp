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
    internal class UserNumber
    {
        private string _chengeTariffDate;
        public Int32 Number { get; set; }
        public Tariff Tariff { get; set; }

        public bool Change
        {
            get;
            set
            {
                // проверим не в этом ли месяце был  если в этом - ругнемся
                if (true)
                {
                    Console.WriteLine("You cann't change tariff because this tariff was changed in this month");
                }
            }
            
        }
    }
}
