using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App
{
    public class PassBy
    {
       

        public void PassByValue(int i, string str)
        {
            i = i + 10;
            str = str + "new";

            Console.WriteLine("Value of i => " + i);
            Console.WriteLine("Value of str => " + str);
        }

        public void PassByReference(ref int a, ref string s)
        {
            a = a + 10;
            s = s + "new";

            Console.WriteLine("Value of i => " + a);
            Console.WriteLine("Value of str => " + s);
        }

        public void PassByOut(int i, string str, out int j, out string strs)
        {
            //the variable that is in is readoonly and cannot be assigned 
           
            j = i + 10;
            strs = str + "new";

            //the variable in out needs to be assigned once 

            Console.WriteLine("Value of i => " + i);
            Console.WriteLine("Value of str => " + str);
          
        }
    }
}
