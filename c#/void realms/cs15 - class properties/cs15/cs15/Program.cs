using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs15
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.Age = 26;
            //p1.Name = "Gen";  //cannot change property as class definition does not allow it

            Console.WriteLine("Name: " + p1.Name);

            Console.WriteLine("Age: " + p1.Age);

            Console.Read();

        }
    }
}
