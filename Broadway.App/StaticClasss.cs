using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App
{
    public static class StaticClasss
    {
        public static int i = 0;
        public static void FunctionOne()
        {

        }
        
    }

    public class NonStaticClass
    {
        public int i = 0;
        public void FunctionOne()
        {
            i++;
            j++;

            Console.WriteLine("i => " + i);
            Console.WriteLine("j => " + j);
        }

        public static int j = 10; 

        public static void StaticFunctionOne()
        {
           
            j++;
        }
    }
}
