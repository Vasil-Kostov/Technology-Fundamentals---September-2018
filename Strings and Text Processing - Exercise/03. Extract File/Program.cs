namespace _03._Extract_File
{
    using System;

    class Program
    {
        static void Main()
        {
            string filePath = Console.ReadLine();

            int fileNameStartIndex = filePath.LastIndexOf('\\') + 1;
            int dotIndex = filePath.LastIndexOf('.');

            string fileName = filePath.Substring(fileNameStartIndex, dotIndex - fileNameStartIndex);
            string extentsion = filePath.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extentsion}");
        }
    }
}
