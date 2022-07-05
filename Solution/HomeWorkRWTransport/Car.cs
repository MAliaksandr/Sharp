namespace HomeWorkRWTransport
{
    // тип вагона
    abstract internal class Car
    {
        // общий метод погрузки/разгрузки
        public abstract void LoadingUnloading(bool moveType, byte count =0);

    }
}
