using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.String
{
    internal class SymbolInfoViewer : FileParseInfo, IReadable, IWriteble
    {
        public SymbolInfoViewer(string filePath, bool outFileOverride)
              : base(filePath, outFileOverride)
        {
        }

        public void ReadInfo()
        {
            using (var strReader = new StreamReader(FilePath))
            {
                var alltext = strReader.ReadToEnd();
            }
        }

        public void RecordResult(string word, int counter)
        {
            using (var sw = new StreamWriter(OutPutFilePath, true))
            {
                sw.WriteLine($"{word.ToString()} ---> {counter}");
            }
        }
    }
}
