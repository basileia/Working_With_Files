using System.Collections.Generic;
using System.IO;

namespace Working_With_Files
{
    class FilesUtility
    {
        public static void CreateDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        public static void CreateFile(string filePath, List<Visit> visits)
        {
            using (var file = File.CreateText(filePath))
            {
                foreach (var visit in visits)
                {
                    file.WriteLine(string.Join(",", visit.Name, visit.Age));
                }
            }
        }

        public static string[] ReadFromFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

    }
}
