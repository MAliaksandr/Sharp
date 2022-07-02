using System.Text;
namespace HomeWorkRWTransport
{
    // пассажирский вагон - наследник вагона в общем смысле
    internal class PassengerCar : Car, IGetInfoable
    {
        // тип вагона и максимальное количество мест, а т.ж. количество занятых мест
        // перегрузим погрузку/разгрузку
        public readonly byte maxPeopleCount;
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
        public PassengerCar(PassengerCarType pasCarType)
        {
            number += 1;
            passengerCarType = pasCarType;

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
            var st = new StringBuilder($"This is type: { passengerCarType}\n");
            st.AppendLine($"All places in this car:{maxPeopleCount}");
            st.AppendLine($"Free people places:{_freePlaceCount}");
            st.AppendLine($"Busy places:{_busyPlaceCount}");

            return st.ToString();
        }
        private void SetPlace(byte value)
        {
            if (((byte)maxPeopleCount - _busyPlaceCount >= value) || (maxPeopleCount> value))
            {
                _busyPlaceCount = value;
                _freePlaceCount = (byte)(maxPeopleCount - value);

            }
            else
            {
                var delta = (byte)(maxPeopleCount - _busyPlaceCount);
                _busyPlaceCount += delta;
                _freePlaceCount = (byte)(maxPeopleCount - delta);
                Console.WriteLine($"We cann't set all {value} people");
                Console.WriteLine($"Stated at platform {value- delta} people :-(");
            }
          
        }
        public override void LoadingUnloading(bool moveType, byte count = 0)
        {
 
        }
    }
}
