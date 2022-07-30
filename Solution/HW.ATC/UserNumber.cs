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
    
    // доавление в лог везде должно идти через многопоточность
    
    internal class UserNumber:IAddLogInfoble
    {
        private DateTime _chengeTariffDate;
        public Int32 Number { get; set; }
        public Tariff Tariff { get; set; }

        public void AddLogInfo(string info)
        {
            var infoWriter = new InfoWriter();

            infoWriter.RecordInfo("");
        }

        // метод позволяющий сменить тариф
        public void ChangeTariff(Tariff tariff)
        {
            if (CalcCurrentDate(_chengeTariffDate) == false)
            {
                var newTariff = new Tariff(tariff);
                                
                // тут же надо событи, уведомляющее компанию что-то вроде event ChangeTariffCompanyInfo
            }
            else
            {
                Console.WriteLine("You cann't change tariff because this tariff was changed in this month");
            }

        }

        // вернет True если изменения были в этом месяце
        private bool CalcCurrentDate(DateTime _chengeTariffDate)
        {
            DateTime dateTime = DateTime.Today;
            var delta = dateTime.Subtract(_chengeTariffDate);

            // в идеале смотреть только месяц... но пока не знаю как)
            if (delta.TotalDays>31)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
