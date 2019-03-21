using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs13
{
    class Person
    {
        public string name = string.Empty;
        public int age = 0;

        public void WelcomeMessage()    //function
        {
            Console.WriteLine("Hello, welcome to my program");
        }

        public static void StaticMessage()    //static function - there can be only 1 instance in class
        {
            Console.WriteLine("this is a static message");
        }

        public string getName() //function to return value of variable
        {
            return name;
        }

        public void setName(string n)   //function to change value of variable
        {
            name = n;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int a)
        {
            age = a;
        }

        /// <summary>
        /// what do you want the person to do
        /// </summary>
        /// <param name="action">action to perform</param>
        /// <param name="nTimes">number of times to perform the action</param>
        public void DoSomething(string action, int nTimes)
        {
            for(int i = 0; i <nTimes; i++)
            {
                Console.WriteLine(action + " " + i + " times");
            }
        }

    }
}
