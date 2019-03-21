using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs08
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Genisha";

            foreach(char c in name)
            {
                Console.WriteLine(c);
            }

            Console.Read();
        }
    }
}
