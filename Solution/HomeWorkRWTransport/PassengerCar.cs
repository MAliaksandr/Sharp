using System.Collections;
using System.Text;
namespace HomeWorkRWTransport
{
    // пассажирский вагон - наследник вагона в общем смысле
    internal class PassengerCar : Car, IGetInfoable, IComparable<PassengerCar>
    {
        // тип вагона и максимальное количество мест, а т.ж. количество занятых мест
        // перегрузим погрузку/разгрузку
        public readonly byte maxPeopleCount;
        public static byte counter=1;
        public readonly byte number;
        public readonly PassengerCarType passengerCarType;
        private byte _freePlaceCount;
        private byte _busyPlaceCount;

        public enum PassengerCarType
        {
            SV,
            K,
            REST,
            P,
            UN,
            M
        }
        public PassengerCar()
        {
            
            // инициализация рандомным типом из ENUM
            Array values = PassengerCarType.GetValues(typeof(PassengerCarType));
            Random random = new Random();
            PassengerCarType pasCarType = (PassengerCarType)values.GetValue(random.Next(values.Length));

            number = counter++;
            passengerCarType = pasCarType;
            //в зависимсти от типа вагона, зависит его вместимость(мак. число пассажиров)
            switch (pasCarType)
            {
                case PassengerCarType.SV:
                    maxPeopleCount = 9*2;            
                    break;
                case PassengerCarType.K:
                    maxPeopleCount = 9*4;
                    break;
                case PassengerCarType.REST:
                    maxPeopleCount = 0;
                    break;
                case PassengerCarType.P:
                    maxPeopleCount = 56;
                    break;
                case PassengerCarType.UN:
                    maxPeopleCount = 81;
                    break;
                case PassengerCarType.M:
                    maxPeopleCount = 60;
                    break;                    
                default:
                    maxPeopleCount = 0;
                    break;
            }          
        }
        public byte BusyPlace
        {
            get => _busyPlaceCount;

            set
            {
                SetPlace(value);
            }
        }
        public string GetInfo()
        {
            var st = new StringBuilder($"CarNumber is {number}\n");
            st.AppendLine($"This is type: { passengerCarType}");
            st.AppendLine($"All places in this car:{maxPeopleCount}");
            st.AppendLine($"Free people places:{_freePlaceCount}");
            st.AppendLine($"Busy places:{_busyPlaceCount}");

            return st.ToString();
        }
        private void SetPlace(byte value)
        {
            if (((byte)maxPeopleCount - _busyPlaceCount >= value) || (maxPeopleCount > value))
            {
                 _busyPlaceCount = value;
                _freePlaceCount = (byte)(maxPeopleCount - value);
            }
            else
            {
                var delta = (byte)(maxPeopleCount - _busyPlaceCount);
                _busyPlaceCount += delta;
                _freePlaceCount = (byte)(maxPeopleCount - delta);
                Console.WriteLine($"We cann't set all {value} people in CarType:{passengerCarType}");
                Console.WriteLine($"Stated at platform {value - delta} people :-(");
                Console.WriteLine("*****");
            }  
        }
        public override void LoadingUnloading(bool moveType, byte count = 0)
        {
            if (moveType)
            {
                if (_freePlaceCount >= count)
                {
                    _busyPlaceCount += count;
                }
            }
            else
            {
                if (_busyPlaceCount >= count)
                {
                    _busyPlaceCount -= count;
                }
                else if (_busyPlaceCount > 0)
                {
                    _busyPlaceCount = 0;
                    count -= _busyPlaceCount;
                }
            }
        }
        public int CompareTo(PassengerCar? other)
        {
            if (maxPeopleCount > other?.maxPeopleCount)
            {
                return 1;
            }
            else if (maxPeopleCount < other?.maxPeopleCount)
            {
                return -1;
            }
            return 0;
        }
    }
}
