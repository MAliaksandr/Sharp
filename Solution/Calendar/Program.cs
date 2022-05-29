using System;

namespace Calendar // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. This application return name day of the week by number");
            Console.WriteLine("Please, enter number of the day or 'EXIT' to exit.");

            string str;
            do
            {
                str = Console.ReadLine();

                int D;
                bool isInt = int.TryParse(str, out D);

                string dayName;

                if (isInt)
                {

                    switch (D)
                    {
                        case 1:
                            dayName = "Mondey";
                            break;
                        case 2:
                            dayName = "Tuesday";
                            break;
                        case 3:
                            dayName = "Wednesday";
                            break;
                        case 4:
                            dayName = "Thursday";
                            break;
                        case 5:
                            dayName = "Friday";
                            break;
                        case 6:
                            dayName = "Saturday";
                            break;
                        case 7:
                            dayName = "Sunday";
                            break;
                        default:
                            dayName = "Not number day of the week!";
                            break;
                    }

                    Console.WriteLine($"This is {dayName}");
                }
                else
                {
                    if (str != "EXIT")
                    { 
                      Console.WriteLine("Please, enter number!");
                    }
                }


            } while (str != "EXIT") ;
         
          
          
        }
    }
 }