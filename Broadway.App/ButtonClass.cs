using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App
{
    public class ButtonClass
    {
        public delegate void ClickDelegate(int a, int b);

        public event ClickDelegate ClickEvent;

        public void Run(int x, int y)
        {
            this.ClickEvent?.Invoke(x, y);
        }
     
    }

    public class ButtonImplClass
    {
        public ButtonClass btnObj = new ButtonClass();
        public ButtonImplClass()
        {
            btnObj.ClickEvent += BtnObj_ClickEvent;
            btnObj.ClickEvent += test;
        }

        private void BtnObj_ClickEvent(int a, int b)
        {
            Console.WriteLine("value of a=>" + a);
            Console.WriteLine("value of b=>" + b);
        }

        void test(int x, int y)
        {
            var res = x+y;
            Console.WriteLine("Sum of z and y are =>" + res);
            
        }

        public void Run(int a, int b)
        {
            btnObj.Run(a, b);
        }
    }
}
