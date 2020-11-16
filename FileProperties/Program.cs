using System;
using System.IO;
using System.Collections.Generic;

namespace FileProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";
            string txt = @"C:\Users\opilane\samples\fileData.txt";
            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            List<string> lines = new List<string>();

            foreach(string file in files)
            {
                var fileData = new FileInfo(file);
                string fileName = fileData.Name;
                string fileDirectory = fileData.DirectoryName;
                long fileSize = fileData.Length / 1000;
                string line = $"File name: {fileName}; is in {fileDirectory}; with size {fileSize} kilobytes (approx).";
                lines.Add(line);
                File.WriteAllLines(txt, lines);
            }
            Console.WriteLine("Written!!");
        }
    }
}
