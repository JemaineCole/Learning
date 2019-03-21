using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    //

namespace cs19
{
    class Program
    {
        static void WriteFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);

            if (fs.CanWrite)
            {
                byte[] buffer = Encoding.ASCII.GetBytes("Hello world");

                fs.Write(buffer, 0, buffer.Length);
            }

            fs.Flush();
            fs.Close();
        }

        static void ReadFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

            if (fs.CanRead)
            {
                byte[] buffer = new byte[1024];
                int bytesRead = fs.Read(buffer, 0, buffer.Length);

                Console.WriteLine(Encoding.ASCII.GetString(buffer, 0, bytesRead));
            }

            fs.Close();
        }

        static void Main(string[] args)
        {
            string filename = @"F:\Work\c#\resources\void realms\cs19 - file streams\cs19\myfile.txt";

            WriteFile(filename);

            ReadFile(filename);

            Console.Read(); ;
        }
    }
}
