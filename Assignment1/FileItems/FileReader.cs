using System;
using System.Collections.Generic;
using System.IO;

namespace Assignment1
{
    class FileReader
    {
        public List<int> ReadFile(string filePath)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName; //Gets projects root directory (So we can find /Files in the actual directory not just the debug directory)
            string sourceFilePath = Path.Combine(projectDirectory,"Assignment1", "Files", Path.GetFileName(filePath));//Sets the path to the correct path, /Assignment1/Files/Share(1,2,3).txt
            string destinationFilePath = Path.Combine(Directory.GetCurrentDirectory(), Path.GetFileName(filePath));//Sets the filepath to Debug so that the txt files can be copied there, to ensure that the file will be where the Reader is looking


            if (!File.Exists(destinationFilePath))//Checking the destination file path does not exist
            {
                if (File.Exists(sourceFilePath))
                {
                    File.Copy(sourceFilePath, destinationFilePath);//Copying the file over to Debug folder for easy use
                }
                else
                {
                    Console.WriteLine($"Source file not found: {sourceFilePath}");
                    return null;
                }
            }

            string[] lines = File.ReadAllLines(destinationFilePath);//Creates string list to hold all lines of txt files
            List<int> integerList = new List<int>();

            foreach (string line in lines)
            {
                if (int.TryParse(line, out int result))
                {
                    integerList.Add(result);
                }
                else
                {
                    Console.WriteLine($"Skipping invalid line: {line}");
                }
            }
            return integerList;
        }
    }
}
