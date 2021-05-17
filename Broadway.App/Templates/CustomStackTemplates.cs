using Broadway.App.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App.Templates
{
    public class CustomTemplatedStack<Ashish>
    {
        public CustomTemplatedStack()
        {
            maxItem = 5;
            container = new Ashish[maxItem];
        }

        public CustomTemplatedStack(int MaxItems)
        {
            maxItem = MaxItems;
            container = new Ashish[maxItem];
        }

        private int maxItem = 10;
        private Ashish[] container;//every item has default value of 0
        private int Counter = 0;

        public void Push(Ashish item)
        {

            if (Counter < maxItem)
            {
                container[Counter] = item;
                Counter++;
            }
        }

        public void Pop()
        {
            if (Counter >= 0)
            {
                Counter--;
            }
        }

        public void Display()
        {
            Console.WriteLine("Items in stack");
            for (int i = Counter - 1; i >= 0; i--)
            {
                Console.WriteLine(container[i]);
            }

            Console.WriteLine();
        }
    }


    public class Test
    {
        public static void FunctionOne<T1, T2>(T1 a, T2 b) where T2: struct
        {
            Console.WriteLine("Type of a is =>" + a.GetType());
            Console.WriteLine("Type of b is =>" + b.GetType());

            Generic1<Rectangle, RectangleAbstract> Obj1 = new Generic1<Rectangle, RectangleAbstract>();
           
        }
    }

    public class Generic1<T, T1> where T: IArea where T1: ShapeAbstract
    {

    }
}
