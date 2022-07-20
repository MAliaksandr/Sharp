using System.IO;
namespace HW.String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"d:\IT-Academy\temp.txt";

            var fileIinfo = new SentenceTextFileViewer(path,true);
            fileIinfo.ReadInfo();
            
            // fileIinfo.SentenceSortByWord();

            // var sentence = new SentenceTextFileViewer(path, true);

            //  var wrd = new WordInfoViewer("Symbol");



        }
    }
}