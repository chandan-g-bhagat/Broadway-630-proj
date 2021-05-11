using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App
{
    public class Arithmetic
    {
        public int i; //null
        public string str;
        public double Price;

        #region Constructors
        //constructor, parameterless constructor
        public Arithmetic()
        {
            i = 10;
        }

        public Arithmetic(int j)
        {
            i = j;
        }
        #endregion

        #region Function Overloading
        public int Add(int a, int b)
        {
            return a + b;
        }
        
        /// <summary>
        /// returns after adding all the numbers
        /// </summary>
        /// <param name="a">integer value</param>
        /// <param name="b">int value</param>
        /// <param name="c">int32 value</param>
        /// <returns></returns>
        public int Add(int a, int b,  int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Takes a number and return by increasing 1
        /// </summary>
        /// <param name="a"> integer value</param>
        /// <returns></returns>
        public int Add(int a)
        {
            return a++;
        }
        #endregion

        public static Arithmetic operator +(Arithmetic a, Arithmetic b)
        {
            var finalresult = a.i + b.i;
            var finalString = a.str + b.str;
            var finalPrice = a.Price + b.Price;
            var res = new Arithmetic() { i = finalresult, str = finalString, Price=finalPrice };
            
            return res;
        }

        public static Arithmetic operator ++(Arithmetic a)
        {
            return new Arithmetic { i = a.i + 1, str = a.str + " " };
        }

        public static bool operator ==(Arithmetic a, Arithmetic b)
        {
            return (a.i == b.i && a.str == b.str);

        }

        public static bool operator !=(Arithmetic a, Arithmetic b)
        {
            return !(a.i == b.i && a.str == b.str);

        }


    }
}
