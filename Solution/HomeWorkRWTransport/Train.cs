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
        }

        public void GetInfo()
        {
            var st = new StringBuilder("I'm a train -)\n");
            st.AppendLine($"My number is {numerTrain}");
            st.AppendLine($"I have a {countCar} cars.");
          
            Console.WriteLine(st);      
        }
        public void Move(bool value, string destination)
        {
            Console.WriteLine($"We going to the {destination}");
            if (!value)
            {
              Console.WriteLine($"But now we are staying...");
            }
        }
        
        private void LoadRandomInTrain(byte countCar)
        {
            var rand = new Random().Next(0,50);

        }
    }
}
