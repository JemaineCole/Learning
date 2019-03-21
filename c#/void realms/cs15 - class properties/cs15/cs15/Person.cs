using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs15
{
    class Person
    {
        //protect class variables by declaring them as private - cannot be changed without a set function
        private string pName = "Geni";
        private int pAge = 0;

        public string Name  //accessors and mutators - cs has built in get and set functions
        {
            get
            {
                return pName;
            }
        }   //if there is no set then variable cannot be modified


        public int Age
        {
            get
            {
                return pAge;
            }
            set
            {
                if (value > 200)
                {
                    pAge = 200;
                }
                else
                {
                    pAge = value;
                }
            }
        }
    }
}
