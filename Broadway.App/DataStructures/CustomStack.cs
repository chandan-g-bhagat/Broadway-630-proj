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
}
