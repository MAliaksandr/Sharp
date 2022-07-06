using System.IO;
namespace HW.Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var PathToFolder = @"d:\Gedemin\Exe\";
            List<string> ls = GetRecursFiles(PathToFolder);
            foreach (string fname in ls)
            {
                Console.WriteLine(fname);
            }
        }
        private static List<string> GetRecursFiles(string start_path)
        {
            List<string> ls = new List<string>();
            try
            {
                string[] folders = Directory.GetDirectories(start_path);
                foreach (string folder in folders)
                {
                    ls.Add("Папка: " + folder);
                    ls.AddRange(GetRecursFiles(folder));
                    ls.Add("***");
                }
                string[] files = Directory.GetFiles(start_path);
                foreach (string filename in files)
                {
                    ls.Add("----Файл: " + filename);
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return ls;
        }
    }
}