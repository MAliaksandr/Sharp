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
    internal class Tariff
    {
       public string TariffName { get; set; }
       public string TariffCost { get; set; }
       public bool ChengeTariff { get; set; }


    }
}
