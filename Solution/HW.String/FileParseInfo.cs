using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.String
{
    internal class FileParseInfo
    {
        internal readonly string FilePath;
        internal readonly string OutPutFilePath;

        // конструктор класса
        public FileParseInfo(string filePath, bool outFileOverride)
        {
            FilePath = filePath;
            // запишем путь к выходному файлу, будет рядом с файлом для чтения
            FileInfo fileInf = new FileInfo(FilePath);
            OutPutFilePath = string.Concat(fileInf.DirectoryName, @"\output.txt");

            if (outFileOverride)
            {
                try
                {
                    using (var f = new FileStream(OutPutFilePath, FileMode.Truncate))
                    {
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception! I didn't owerride outputfile {ex.ToString}");
                }
            }
        }
    }
}    
