using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App
{
    public class ArraysFunction
    {
        public static void ArrayExample1()
        {
            int[] i = new int[3];
            i[0] = 10;
            i[1] = 20;
            i[2] = 30;

            Array.Reverse(i);


            Console.ReadLine();
            //i[3] = 40;
        }

    }
}
