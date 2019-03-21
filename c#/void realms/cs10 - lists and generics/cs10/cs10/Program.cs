using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> family = new List<string>();

            family.Add("Jame");  //0
            family.Add("Gen");   //1
            family.Add("Clint"); //2
            family.Add("Sudh");  //3
            family.Add("Ri");    //4

            foreach(string member in family)
            {
                Console.WriteLine(member);
            }

            Console.WriteLine("");
            Console.WriteLine("Along came Peni");
            Console.WriteLine("");

            family.Insert(3, "Peni");   //inserts string to 3rd position of List

            foreach (string member in family)
            {
                Console.WriteLine(member);
            }


            Console.Read();

        }
    }
}
