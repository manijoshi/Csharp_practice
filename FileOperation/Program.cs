using System;
using System.IO;
using System.Linq;


namespace FileOperation
{
    public class Program
    {
        public static void Main()
        {

            string path = @"C:\Tasks\DuckSimulationGame\DuckGameBusinessLayer";
            var dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();

            // Count of text files in a directory
            Console.WriteLine("\n.txt file in the direcotry:-");
            Console.WriteLine(".txt - " + GetCountFormat(".txt", files));

            // Number of files per extension type
            Console.WriteLine("\nNumber of files per extension type:-");
            GetFormats(files).ToList().ForEach(x => Console.WriteLine(x + " - " + GetCountFormat(x, files)));

            // Top 5 largest files, along with their size
            Console.WriteLine("\nTop 5 largest files with their size:-");
            GetCountBytes(files,5).ToList().ForEach(x => Console.WriteLine(x.FullName+" "+x.Length));

            //Return the file with max. length
            Console.WriteLine("\nReturn the file with maximum length:-");
            GetCountBytes(files, 1).ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.ReadLine();

        }
        private static int GetCountFormat(string format,FileInfo[] files)
        {
            if (format.Contains(".") == false)
                format = "." + format;
            return files.ToList().Where(f => f.FullName.Contains(format)).Count();
        }
        private static string[] GetFormats(FileInfo[] files)
        {
            return files.Where(x => x.FullName.Contains('.')).Select(x => x.FullName.Remove(0, x.FullName.IndexOf("."))).Distinct().ToArray();
        }
        private static FileInfo[] GetCountBytes(FileInfo[] files, int countsReceive = 1)
        {
            files = files.OrderBy(x => -x.Length)
                         .ToArray();
            FileInfo[] answer = new FileInfo[countsReceive];
            Array.Copy(files, 0, answer, 0, countsReceive);
            return answer;
        }

    }
}
