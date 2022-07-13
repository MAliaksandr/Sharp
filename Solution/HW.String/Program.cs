using System.IO;
namespace HW.String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"d:\IT-Academy\temp.txt";

            var fileIinfo = new SentenceTextFileViewer(path,true);

            fileIinfo.SentenceSortByWord();

            //using (StreamReader reader = new StreamReader(path))
            //{
            //    var text =  reader.ReadToEnd();



            // var charQuantity= new Char[(long)reader.BaseStream.Length];

            // Console.WriteLine($"All char in this file :{charQuantity.Length}");

            // var words = text.Split(" ");

            // var counter = 0;
            //for (int i = 0; i < words.Length; i++) 
            // {
            //     if (counter == 500)
            //     {
            //         break;
            //     }
            //     counter++;
            // }
            // }          
        }
    }
}