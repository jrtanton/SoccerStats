using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SoccerStats
{
    class Program
    {
        static void Main(string[] args)
        {

            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);

            var files = directory.GetFiles("*.txt");

            foreach(var file in files)
            {
                Console.WriteLine(file.Name);
            }

        }
    }
}
