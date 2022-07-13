using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Temp.String
{
    internal class FileInfoViewer
    {

        public FileInfoViewer(string filePath)
        {
            try
            {
                using (var strReader = new StreamReader(filePath))
                {

                    // var value = strReader.ReadLine();

                    // считали строку Console.WriteLine(strReader.ReadLine()); 

                    // разделілі Console.WriteLine("******_******");

                   var alltext = strReader.ReadToEnd();

                    // считали до конца файла, начав с текущего положения курсора
                    // Console.WriteLine(strReader?.ReadToEnd()); 
                    // var endVal = strReader.Peek(); -1 если конец файла
                    
                    string sentencePatern = @"(?<=\.\.\.|\.)";

                    // var alltext = @"Cons She said, You deserve a treat! deserve";

                    var matches = Regex.Split(alltext, sentencePatern); //, RegexOptions.Compiled | RegexOptions.IgnoreCase);

                    //MatchCollection matches = rx.Matches(alltext);

                    //Console.WriteLine("{0} matches found in:\n   {1}",
                    //                  matches.Count,
                    //                  alltext);
                    var counter = 1;
                    Console.WriteLine($"counts: {matches.Length-1}");

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

    

    }
}
