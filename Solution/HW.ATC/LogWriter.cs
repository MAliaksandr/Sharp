using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.ATC
{   // статический класс работы с лог файлом,
    // поскольку предполагается, что лог-файл будет единственным 
    internal static class LogWriter
    {
        internal static string FilePath;

        public static void InitLogWriter(string filePath)
        {
            FilePath = filePath;
            
            // запишем путь к файлу лога
            if (filePath != null)
            {
               try
               {
                    using var f = new FileStream(filePath, FileMode.OpenOrCreate);
               }
               catch (Exception ex)
                    {
                        Console.WriteLine($"Exception! I didn't open or create logfile {ex.ToString}");
                    }
            }
        }

        public static string GetLogFilePath()
        {
            return FilePath;
        }
    }
}
