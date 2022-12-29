using System.IO;
using System;
namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\BITTALUK\Desktop\CsharpAssignment6";

            var dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            var files = Directory.GetFiles(rootPath, "*.txt", SearchOption.AllDirectories);

            Console.WriteLine("Display directories");
            foreach (string dir in dirs)
            {
                var dirInfo = new DirectoryInfo(dir);
                Console.WriteLine($"{dirInfo.FullName}");
            }
            Console.WriteLine("\n--Display all .txt files");
            foreach (string file in files)
            {
                var fileInfo = new FileInfo(file);
                Console.WriteLine($"{Path.GetFileName(file)} - { fileInfo.Length } bytes");
            }
        }
    }
}
