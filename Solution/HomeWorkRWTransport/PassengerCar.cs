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
        public override void LoadingUnloading(bool moveType, byte count)
        {
                if (moveType)
                {
                    //  loading...             
                    if (maxPeopleCount <= _busyPlaceCount + count)
                    {
                        _busyPlaceCount += count;
                        _freePlaceCount = (byte)(maxPeopleCount - _busyPlaceCount);
                    }
                    else
                    {
                        Console.WriteLine($"Willn't add more people then max in car {maxPeopleCount}");
                    }
                }
                else   //unloading...  
                {
                    if (count <= _busyPlaceCount)
                    {
                        _busyPlaceCount -= count;
                        _freePlaceCount = (byte)(maxPeopleCount - _busyPlaceCount);
                    }
                    else
                    {
                        Console.WriteLine($"We cann't out of more people then exists in car {_busyPlaceCount}");
                    }
                }
        }

        public void GetInfo()
        {
            Console.WriteLine($"This is type. {passengerCarType}");
            Console.WriteLine($"All places in this car:{maxPeopleCount}");
            Console.WriteLine($"Free people places:{_freePlaceCount}");
            Console.WriteLine($"Busy places:{_busyPlaceCount}");
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
    }
}
