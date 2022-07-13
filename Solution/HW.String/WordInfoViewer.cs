using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.String
{
    internal class WordInfoViewer : FileParseInfo, IReadable, IWriteble
    {
        public List<string> words;
        public WordInfoViewer(string filePath,
                              bool outFileOverride) : base(filePath, outFileOverride)
        {
        }
        public void ReadInfo()
        {
            using (var strReader = new StreamReader(FilePath))
            {
                var alltext = strReader.ReadToEnd();

                char[] separator = { ' ', ',', '.', ':', '!', '?', ';', ';', '-', '\t', '\n' };

                words = alltext.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        }

        public void RecordResult(string word, int counter)
        {
                if (word is null)
                {
                    throw new ArgumentNullException("Dont't used null value");
                }

                using (var sw = new StreamWriter(OutPutFilePath, true))
                {
                    sw.WriteLine($"{word.ToString()} ---> {counter}");
                }
            }

        private int GetWordCount(string word, List<string> collection)
        {
            var counter = 1;
            foreach (var item in collection)
            {
                if (item.ToString() == word)
                {
                    counter++;
                }
            }
            return counter;
        }

        public void SortByWord()
        {
            words.Sort();

            var newCollection = new List<string>();

            // создаем коллекцию, исключая одинаково встречающиеся слова
            foreach (var item in words)
            {
                if (!newCollection.Exists(x => x.ToString() == item.ToString()))
                {
                    newCollection.Add(item);
                }
            }

            foreach (var word in newCollection)
            {
                RecordResult(word, GetWordCount(word, words));
            }

        }
    }
}
