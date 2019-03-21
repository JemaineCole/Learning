using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //add this namespace for file io

namespace cs18
{
    class Program
    {
        static void WriteFile(string FilePath)
        {
            File.WriteAllText(FilePath, "Hello world that opened this file");   //File.WriteAllText is built in function
        }

        static void ReadFile(string FilePath)
        {
            Console.WriteLine(File.ReadAllText(FilePath)); //File.ReadAllText is built in function
        }

        static void Main(string[] args)
        {
            string myFilePath = @"F:\Work\c#\resources\void realms\cs18 - basic file io\cs18\myfile.txt";   //add @ to full qualified path

            WriteFile(myFilePath);

            ReadFile(myFilePath);

            Console.Read();
        }
    }
}
