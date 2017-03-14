using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace movieMover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path of the folder.");
            string folderPath = Console.ReadLine();
            DirectoryInfo d = new DirectoryInfo(folderPath);

            foreach (var file in d.GetFiles())
            {
                string fileName = file.Name;
                string movieName = fileName.Remove(fileName.Length - 4);
                string newPath = folderPath + "\\" + movieName + "\\" + fileName;
                Directory.CreateDirectory(folderPath + "\\" + movieName);
                file.MoveTo(newPath);
            }
            Console.WriteLine("Done");
        }
    }
}
