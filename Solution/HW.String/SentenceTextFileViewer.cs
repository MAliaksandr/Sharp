using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace HW.String
{
    internal class SentenceTextFileViewer : FileParseInfo, IReadable, IWriteble //, IComparable<SentenceTextFileViewer>
    {
        public List<string> Sentences;

        public SentenceTextFileViewer(string filePath, bool outFileOverride) : base(filePath, outFileOverride)
        {
        }

        //public int CompareTo(SentenceTextFileViewer? other)
        //{
            
        //}

        public void ReadInfo()
        {
            try
            {
                using (var strReader = new StreamReader(FilePath))
                {
                    var alltext = strReader.ReadToEnd();

                    string sentencePatern = @"(?<=\.\.\.|\.)";

                    var matches = Regex.Split(alltext, sentencePatern);

                    var counter = 1;
                    Console.WriteLine($"counts: {matches.Length}");

                    foreach (var item in matches)
                    {
                        Console.WriteLine($"{item.ToString()}");
                        if (matches.Length - 1 > counter)
                        {
                            counter++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Smth wrong with this file...{ex.ToString()}");
            }
        }

        public void RecordResult(string word, int counter)
        {
            
        }
        public void SentenceSortByWord()
        {
                using (var strReader = new StreamReader(FilePath))
                {
                    var alltext = strReader.ReadToEnd();

                }
        }

    }
}
