 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs13
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.WelcomeMessage();    //calliing function

            Person.StaticMessage(); //calling static function - cannot call by object but only by class

            Console.WriteLine("");

            p1.setName("Geni");
            Console.WriteLine(p1.getName());

            p1.setAge(26);
            Console.WriteLine(p1.getAge());

            p1.DoSomething("smile", 8);
            

            Console.Read();
        }
    }
}
