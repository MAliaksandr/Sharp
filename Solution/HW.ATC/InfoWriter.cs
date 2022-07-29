using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.ATC
{
    // пишем в файл
    internal class InfoWriter
    {
       public void RecordInfo(string info)
        {
            if (info != null)
            { 
                try
                {
                    using (var sw = new StreamWriter(LogWriter.FilePath, true))
                    {
                        sw.WriteLine($"{info}");
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Cann't write info: {info} into file {ex.ToString}"); 
                }
            }
        }


    }
}
