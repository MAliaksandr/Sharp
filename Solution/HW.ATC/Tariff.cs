using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.ATC
{ 
    // тарифный план имеет:
    // название
    // стоимость за 1с
    // доп услуги

    // хорошо бы использовать информирование всех абонентов с тарифом об изменениях стоимости (событие)
    //
    internal class Tariff
    {
        private Tariff tariff;

        public Tariff(Tariff tariff)
        {
            this.tariff = tariff;
        }

        private int Id { get; set; }
       public string TariffName { get; set; }
       public string TariffCost { get; set; }
       public bool ChengeTariff { get; set; }

    }
}
