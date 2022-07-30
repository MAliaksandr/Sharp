using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HW.ATC
{
    // читаем из файла
    internal class InfoReader
    {

		public void ReadInfo()
        {
			try
			{
				using (var strReader = new StreamReader(LogWriter.GetLogFilePath()))
				{
					var strLine = strReader.ReadLine;
					var sb = new StringBuilder();


					// просто выводим на консоль
					// в идеале куда-то еще выводить, м.б. даже по запросу
					while (!strReader.EndOfStream)
                    {
                        Console.WriteLine($"{strLine.ToString}");
                    }
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Cann't read logfile {ex.ToString}");
			}
		}

		// перегрузим метод параметром
		public void ReadInfo(UserNumber userNumber)
		{
			try
			{
				using (var strReader = new StreamReader(LogWriter.GetLogFilePath()))
				{
					var lineinfo = strReader.ReadLine;
					var NewList = new List<UserNumber>();
					var sb = new StringBuilder();

					// создали коллекцию из лога
					while (!strReader.EndOfStream)
                    {
						NewList.Add(lineinfo.ToString());
					}

					var numberInfo = NewList.Where(n => n.Number).ToList();

                    foreach (var item in numberInfo)
                    {
						sb.AppendLine($"{item.number} -  - -")

					}

					// просто выводим на консоль
					// в идеале куда-то еще выводить, м.б. даже по запросу
					while (!strReader.EndOfStream)
					{
						Console.WriteLine($"{strLine.ToString}");
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Cann't read logfile {ex.ToString}");
			}
		}

	}
}
