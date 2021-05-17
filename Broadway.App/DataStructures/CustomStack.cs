using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App.DataStructures
{
    public class CustomStack
    {
        public CustomStack()
        {
            maxItem = 5;
            container = new string[maxItem];
        }

        public CustomStack(int MaxItems)
        {
            maxItem = MaxItems;
            container = new string[maxItem];
        }

        private int maxItem;
        private string[] container;//every item has default value of 0
        private int Counter = 0;

        public void Push(string item)
        {
            if (Counter<maxItem)
            {
                container[Counter] = item;
                Counter++;
            }
        }

        public void Pop()
        {
            if (Counter>=0)
            {
                container[Counter] = "";
                Counter--;
            }
        }

        public void Display()
        {
            Console.WriteLine("Items in stack");
            for (int i = Counter-1; i >= 0; i--)
            {
                Console.WriteLine(container[i]);
            }

            Console.WriteLine();
        }
    }

    public class CustomStackDouble
    {
        public CustomStackDouble()
        {
            maxItem = 5;
            container = new double[maxItem];
        }

        public CustomStackDouble(int MaxItems)
        {
            maxItem = MaxItems;
            container = new double[maxItem];
        }

        private int maxItem;
        private double[] container;//every item has default value of 0
        private int Counter = 0;

        public void Push(double item)
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
                container[Counter] = 0;
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


    public class CustomInifiniteStack
    {
        private string[] container = new string[0]; //initial container size is 1
        

        public void Push(string item)
        {
            Array.Resize(ref container, container.Length + 1);            
            //container.Length-1 gives us index
            container[container.Length-1] = item;
        }

        public void Pop()
        {
            if (container.Length >= 0)
            {
                Array.Resize(ref container, container.Length - 1);
            }
        }

        public void Display()
        {
            Console.WriteLine("Items in stack");
            for (int i = container.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(container[i]);
            }

            Console.WriteLine();
        }
    }



  
}
