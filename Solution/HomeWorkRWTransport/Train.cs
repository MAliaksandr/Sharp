using System.Text;
namespace HomeWorkRWTransport
{
    internal class Train : IMoveable, IGetInfoable
    {
        public readonly byte countCar;
        public readonly string numerTrain;
        public readonly PassengerCar passCar;

        public Train(byte countCar, string numerTrain)
        {
            this.countCar = countCar;
            this.numerTrain = numerTrain;

            LoadRandomInTrain(countCar);
        }

        public string GetInfo()
        {
            var st = new StringBuilder("I'm a train -)\n");
            st.AppendLine($"My number is {numerTrain}");
            st.AppendLine($"I have a {countCar} cars.");
          
           return st.ToString();      
        }
        public void Move(bool value, string destination)
        {
            Console.WriteLine($"We going to the {destination}");
            if (!value)
            {
              Console.WriteLine($"But now we are staying...");
            }
        }
        public void LoadRandomInTrain(byte countCar)
        {
            var rand = new Random();

            var array = new IGetInfoable[countCar];
            var resut = array;


            for (int i = 1; i <= countCar; i++)
            {
                array[i - 1] = new PassengerCar(PassengerCar.PassengerCarType.P)
                {
                    BusyPlace = (byte)rand.Next(0, 50)
                };
            }

            GetInfoByTrain(array);
        }
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
    }
}
