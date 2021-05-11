using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    public class Class1
    {
        Class2 obj = new Class2();
       
    }

    internal class Class2
    {
        
    }
}

namespace NewNameSpace
{
    class TestNew
    {
        TestClass.Class2 obj = new TestClass.Class2();
    }
}
