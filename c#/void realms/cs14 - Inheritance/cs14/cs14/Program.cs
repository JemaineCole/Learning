using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs14
{
    class Program
    {
        static void Main(string[] args)
        {
            Feline f1 = new Feline();
            Canine c1 = new Canine();

            Lion l1 = new Lion();
            Wolf w1 = new Wolf();

            l1.Roar();
            w1.Howl();

            //if you instantiate any object you will see that it has all the properties of inherited classes

            Console.Read();

   
        }
    }
}
