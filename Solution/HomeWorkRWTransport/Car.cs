namespace HomeWorkRWTransport
{
    // тип вагона
   
    abstract internal class Car
    {
        enum CarType
        {
            boxCar,
            passengerCar
        }
        public byte CarNumer;

        // общий метод погрузки/разгрузки
        public abstract void LoadingUnloading(bool moveType, byte count =0);

    }
}
