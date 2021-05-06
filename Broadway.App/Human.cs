using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App
{
    public class Human
    {
        //Constructor : runs onetime throughout the object lifecycle
        public Human()
        {
            //e = 1.7;
            //pi = 1.14; //not valid
        }
        //variable
        int j = 10;
        const double pi = 3.14;
        readonly double e = 2.7;
        //properties
        int number { get; set; }
        //methods or functions
        void SomeFunctiuon()
        {
            //pi = 2.14;
            //e = 3.7;
        }
       //GC handles all the things, instead we use IDispossable

    }
}
