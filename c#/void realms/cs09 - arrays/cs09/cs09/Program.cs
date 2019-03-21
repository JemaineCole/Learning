using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] People = new string[6];

            People[0] = "Gen";
            People[1] = "Jame";
            People[2] = "Sudhs";
            People[3] = "Ri";
            People[4] = "Clint";
            People[5] = "Pen";

            foreach(string s in People)
            {
                Console.WriteLine(s);
            }

            Console.Read();
        }
    }
}
