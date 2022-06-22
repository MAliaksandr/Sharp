using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3Classes
{
    internal class Money
    {
        private long rub;
        private byte kop;

        public long GetRub
        {
            get 
            { 
                return rub; 
            }
            private set
            {
                rub = value;
            }
        }
        public byte GetKop
        {
            get
            {
                return kop;
            }
            private set 
            { 
                kop = value;
            }
        }

        public Money(double value)
        {
            var intPartValue = (int)value;

            var fracPartValue = (value - intPartValue).ToString();

            var LenfracPartValue = fracPartValue.Length-2; //-2 т.к отсекаем целую часть и запятую

            var arr = value.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            var tempRub = Convert.ToInt64(arr[0]);

            var tempKop = Convert.ToInt32(arr[1]);

            do
            {
                if (tempKop > 99)
                {
                    tempKop -= 100;
                    tempRub += 1;
                }
            } while (tempKop > 99);

            this.rub = tempRub;

            this.kop = Convert.ToByte(tempKop);
        }
    }
}
