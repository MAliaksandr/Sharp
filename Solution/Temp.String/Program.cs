namespace Temp.String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // var stR = new FileInfoViewer(@"d:\IT-Academy\sample.txt");
            var path = @"d:\IT-Academy\sample.txt";

            var str = new FileInfo(path);

            var dir = str.DirectoryName;
            
            Console.WriteLine(dir);
            
        }
    }
}