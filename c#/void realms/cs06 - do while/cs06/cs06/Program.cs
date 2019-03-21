using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs06
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            //do while loop
            do
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter < 10);


            //while loop
            while(counter >= 0)
            {
                Console.WriteLine(counter);
                counter--;
            }



            Console.Read();
        }
    }
}
