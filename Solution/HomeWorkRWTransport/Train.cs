using System.Text;
namespace HomeWorkRWTransport
{
    internal class Train : IMoveable, IGetInfoable
    {
        public readonly byte countCar;
        public readonly string numberTrain;
        private readonly PassengerCar passCar;
        public List<PassengerCar> trainCollectCars;

        // конструктор с инициализацией коллекции вагонов
        public Train(byte countCar, string numberTrain)
        {
            this.countCar = countCar;
            this.numberTrain = numberTrain;

            trainCollectCars = new List<PassengerCar>(LoadRandomInTrain(countCar));
        }
        // общая инфа о составе
        public string GetInfo()
        {
            var st = new StringBuilder("I'm a train -)\n");
            st.AppendLine($"My number is {numberTrain}");
            st.AppendLine($"I have a {countCar} cars.");
          
           return st.ToString();      
        }
        // движение состава
        public void Move(bool value, string destination)
        {
            Console.WriteLine($"We going to the {destination}");
            if (!value)
            {
              Console.WriteLine($"But now we are staying...");
            }
        }
        // инициализация состава рандомным числом пассажиров
        public PassengerCar[] LoadRandomInTrain(byte countCar)
        {
            var rand = new Random();
            var array = new PassengerCar[countCar];
            for (int i = 1; i <= countCar; i++)
            {
                array[i - 1] = new PassengerCar()
                {
                    // заполняем рандомным числом пассажиров
                    BusyPlace = (byte)rand.Next(0, 50)
                    
                };
            }   
            GetInfoByTrain(array);
            return array;
        }
        // выводит инфу по каждому вагону в созданном составе
        private void GetInfoByTrain(IGetInfoable[] trainCars)
        {
            var sb = new StringBuilder();
            foreach (var item in trainCars)
            {
                sb.AppendLine(item.GetInfo());
                sb.AppendLine("------------");
            }
            Console.WriteLine(sb);
        }
        private void SortByMaxCount(List<PassengerCar>  trainCollectCars)
        {
            trainCollectCars.Sort();
            foreach (var item in trainCollectCars)
            {
                var sb = new StringBuilder();
                sb.Append($"CarType: {item.passengerCarType}");
                sb.Append($"--MaxPeopleCount:{item.maxPeopleCount}");

                Console.WriteLine(sb);
            }
        }
        public void SortCar()
        {
            SortByMaxCount(trainCollectCars);
        }
        // подсчитаем общую вместимость состава
        public int GetTrainCapacity()
        {
            var countPeople = 0;
            foreach (var item in trainCollectCars)
            {
                countPeople += (int)item.maxPeopleCount;
            }
            return countPeople;
        }
        // колчество едущих пассажиров и богажа
        public void GetPeopleAndBaggageInWay()
        {
            var countPeople = 0;
            var baggage = 0;
            foreach (var item in trainCollectCars)
            {
                countPeople += (int)item.BusyPlace;
            }
            baggage = countPeople*2;
            Console.WriteLine($"\n\tCount people, " +
                $"who in the way now: {countPeople} and baggage: {baggage}");
        }
        // покажет 
        public byte GetCarForPeopleCount(byte vallue)
        {


            return (byte)vallue;
        }
    }
}
