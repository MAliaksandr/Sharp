using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.ATC
{

    // абонет имеет:
    // идентификатор
    // номер
    // дата заключения договора
    // тарифный план

    // абонент может:
    // звонить   ---> запись в ЛОГ через событие
    // менять тариф (1 раз в месяц) ---> запись в ЛОГ через событие
    // отключать/подключать телефон к порту ---> иинформирование компании через событие доступен/не доступен
    // получить детализацию

    public delegate void LogInformationHandler (string logInfo);

    internal class Subscriber
    {
        private event LogInformationHandler Notify;





    }
}
