using System;
using System.Collections.Generic;
using System.IO;

namespace Working_With_Files
{
    class GuestBook
    {
        public List<Visit> Visits { get; set; }

        private readonly string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private readonly string directory = "Czechitas";
        private readonly string fileName = "visits.csv";

        private string PathToFile
        {
            get
            {
                return Path.Combine(pathToDesktop, directory, fileName);
            }
        }

        public GuestBook()
        {
            Visits = new List<Visit>();
            if (File.Exists(PathToFile))
            {
                FileDataProcessing();
            }
        }
        
        public void AddVisit(string name, int age)
        {
            Visit visit = new Visit(name, age);
            Visits.Add(visit);
        }

        public void CreateFile()
        {
            FilesUtility.CreateDirectory(Path.Combine(pathToDesktop, directory));
            FilesUtility.CreateFile(PathToFile, Visits);
        }

        public void FileDataProcessing()
        {
            string[] fileContent = FilesUtility.ReadFromFile(PathToFile);
            Visits.Clear();

            foreach (string line in fileContent)
            {
                var objectVisit = line.Split(',');
                if (int.TryParse(objectVisit[1], out int age))
                {
                    AddVisit(objectVisit[0], age);
                }
                else
                {
                    Console.WriteLine("String could not be parsed.");
                }
            }
        }

        public void ViewVisits()
        {
            Visits.ForEach(x => Console.WriteLine(x));
        }

    }
}
