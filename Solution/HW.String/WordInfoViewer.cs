using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.String
{
    internal class WordInfoViewer : FileParseInfo, IReadable, IWriteble
    {
        public string WordWithMinLatters 
        { 
            get => WordWithMinLatters; 
            set 
            {
                WordWithMinLatters = value;
            } 
        }
        public string WordWithMaxLatters 
        { 
            get => WordWithMaxLatters;
            set
            {
                WordWithMinLatters = value;
            } 
        }

        public int LetterCount
        {
            get => LetterCount;
            set 
            {
                LetterCount = value;
            }
        }

        public List<string> words;
        public WordInfoViewer(string filePath,
                              bool outFileOverride) : base(filePath, outFileOverride)
        {
        }
        // конструктор для передачи просто слова(без файла)
        public WordInfoViewer(string word) : base(null, true)
        {
            LetterCount = GetLetterInWord(word);

            this.WordWithMinLatters = word;
            this.WordWithMaxLatters = word;
        }
        public void ReadInfo()
        {
            try
            {
                using (var strReader = new StreamReader(FilePath))
                {
                    var alltext = strReader.ReadToEnd();

                    char[] separator = { ' ', ',', '.', ':', '!', '?', ';', ';', '-', '\t', '\n' };

                    words = alltext.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Cann't read file {ex.ToString}");
            }
            
        }

        public void RecordResult(string word, int counter)
        {
            if (word is null)
            {
               throw new ArgumentNullException("Dont't used null value");
            }

            try
            {
                using (var sw = new StreamWriter(OutPutFilePath, true))
                {
                    sw.WriteLine($"{word.ToString()} ---> {counter}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cann't write WORDS into file {ex.ToString}");
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

        public int GetLetterInWord(string word)
        {
            var counter = 0;
            foreach (var item in word)
            {
                counter++;
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
            // пишем в файл
            foreach (var word in newCollection)
            {
                RecordResult(word, GetWordCount(word, words));
            }

        }
    }
}
