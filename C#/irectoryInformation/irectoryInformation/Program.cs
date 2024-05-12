using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInformation
{
    class DirectoryInformation
    {
        static void Main(string[] args)
        {
            string directoryName;
            string[] listOfFiles;
            Write("Enter a folder >> ");
            directoryName = ReadLine();
            if (Directory.Exists(directoryName))
            {
                WriteLine("Directory exists, and it contains the following");
                listOfFiles = Directory.GetFiles(directoryName);
                for (int x = 0; x < listOfFiles.Length; ++x)
                    WriteLine("   {0}", listOfFiles[x]);
            }
            else
            {
                WriteLine("Directory {0} does not exist", directoryName);
            }
        }
    }
}
