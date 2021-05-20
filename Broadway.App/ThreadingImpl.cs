using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Broadway.App
{
    public class ThreadingImpl
    {
        public static void FunctionOne()
        {
            Console.WriteLine("Call from Function One : 1" );
            Thread.Sleep(5000);
            Console.WriteLine("Call from Function One : 2");
            Thread.Sleep(5000);

            Console.WriteLine("Call from Function One : 3");
            Thread.Sleep(5000);

            Console.WriteLine("Ended Function One");

        }

        public static void FunctionTwo()
        {
            Console.WriteLine("Call from function two : 1" );
            Thread.Sleep(3000);
            Console.WriteLine("Call from function two : 2");
            Thread.Sleep(3000);
            Console.WriteLine("Call from function two : 3");
            Thread.Sleep(3000);
            Console.WriteLine("Call from function two : 4");
            Thread.Sleep(3000);
            Console.WriteLine("Ended Function Two");
        }

        public static void FunctionThree(string str)
        {
            Console.WriteLine("Call from function Three : 1 "+str);
            Thread.Sleep(2000);
            Console.WriteLine("Call from function Three : 2 " + str);
            Thread.Sleep(2000);
            Console.WriteLine("Call from function Three : 3 " + str);
            Thread.Sleep(2000);
        }

        public static void TaskOne()
        {
            Console.WriteLine("Call from Task One : 1");
            Thread.Sleep(5000);
            Console.WriteLine("Call from Task One : 2");
            Thread.Sleep(5000);

            Console.WriteLine("Call from Task One : 3");
            Thread.Sleep(5000);

            Console.WriteLine("Ended Task One");

        }

        public static void TaskTwo()
        {
            Console.WriteLine("Call from Task two : 1");
            Thread.Sleep(3000);
            Console.WriteLine("Call from Task two : 2");
            Thread.Sleep(3000);
            Console.WriteLine("Call from Task two : 3");
            Thread.Sleep(3000);
            Console.WriteLine("Call from Task two : 4");
            Thread.Sleep(3000);
            Console.WriteLine("Ended Task Two");
        }

        public static void TaskThree(string str)
        {
            Console.WriteLine("Call from Task Three : 1 " + str);
            Thread.Sleep(2000);
            Console.WriteLine("Call from Task Three : 2 " + str);
            Thread.Sleep(2000);
            Console.WriteLine("Call from Task Three : 3 " + str);
            Thread.Sleep(2000);
        }
    }
}
