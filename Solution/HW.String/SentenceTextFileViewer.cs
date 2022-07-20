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
        private string _minWordSentence="";
        private string _maxSymbolSentence="";

        private string MinWordSentence { get => _minWordSentence; set => _minWordSentence = value; }
        private string MaxSymbolSentence { get => _maxSymbolSentence; set => _maxSymbolSentence = value; }
        public SentenceTextFileViewer(string filePath, bool outFileOverride)
               : base(filePath, outFileOverride)
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
                    var counter = 0;
                    var INFO_SENTENCE = "**** Record all sentences to new file ****";
                    var sb = new StringBuilder();


                    for (int i = 0; i < matches.Length-1; i++)
                    {
                        if (matches[i] != null)
                        {
                            sb.AppendLine(matches[i].ToString());
                            counter++;
                            GetSentenceByMinWord(matches[i].ToString());
                        }
                    }
                    
                    sb.AppendLine();
                    sb.AppendLine($"Sentence with most symbols:{Environment.NewLine}{MaxSymbolSentence}");
                    sb.AppendLine($"Sentence with min words:{Environment.NewLine}{MinWordSentence}");

                    RecordResult(sb?.ToString(), INFO_SENTENCE, counter); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Smth wrong with this file...{ex?.ToString()}");
            }

        }

        public void RecordResult(string word, string info, int counter)
        {
            if (word is null)
            {
                throw new ArgumentNullException("Dont't used null value");
            }

            try
            {
                using (var sw = new StreamWriter(OutPutFilePath, true))
                {
                    sw.WriteLine($"{info}");
                    sw.WriteLine($"{word.ToString()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cann't write sentences into file {ex.ToString}");
            }
        }
    
        // сравнивает и записывает предложение с мин кол-вом слов/символов
        public void GetSentenceByMinWord(string sentece)
        {
            //  пол количеству символов 

            if (MaxSymbolSentence?.Length == 0 || sentece?.Length > MaxSymbolSentence?.Length)
            {
                MaxSymbolSentence = sentece.ToString();
            }

            // по количеству слов                       

            if (MinWordSentence?.Length==0 || GetWordCount(sentece) < GetWordCount(MinWordSentence))
            {
                MinWordSentence = sentece.ToString();
            }

        }

        // количество слов в предложении
        private int GetWordCount(string sentece)
        {
            var counter = 0;
            var matches = Regex.Split(sentece, " ");

            foreach (var word in matches)
            {
                counter++;
            }
            return counter;
        }
    }
}
