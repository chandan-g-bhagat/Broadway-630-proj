using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App
{
    class Program
    {
        static void Main(string[] args)
        {
            // ctrl + k,c => comment
            //ctrl + k,u => uncomment
            //int a = 10;
            //a++;
            //a++;

            //Maths m1 = new Maths();
            //Maths m2 = new Maths();




            //Console.WriteLine("I am from .net framework"); // at the end adds a new line
            //Console.Write("Hello, I am Kushal Neupane"); // simply writes
            //var str =Console.ReadLine();

            //Console.WriteLine("Input from user => "+str);




            //DataTypeRepresentation();

            //CastingExample();

            PropertiesExample();

            Console.ReadLine();
        }
        static void PropertiesExample()
        {
            ScienceSubject science = new ScienceSubject();
            science.MarksObtained = -30;

            Console.WriteLine("Marks in science => " + science.MarksObtained);

            Student s = new Student();
            s.FName = "Subham123";
            s.LName = "Koirala";
            Console.WriteLine("Student FullName => " + s.FullName);

            Student s1 = new Student();
            s1.FName = "Subham";
            s1.LName = "Koirala";
            Console.WriteLine("Student FullName => " + s1.FullName);





            StudentNew sNew = new StudentNew();
            sNew.FName = "Saroj";
            sNew.LName = "Koirala";

            Console.WriteLine("Student FullName => " + sNew.FName+"-"+sNew.LName);

            StudentNew sNew1 = new StudentNew();
            sNew1.FName = "Saroj";
            sNew1.LName = "Koirala";

            Console.WriteLine("Student FullName => " + sNew1.FName + "-" + sNew1.LName);


        }

        static void DataTypeRepresentation()
        {
            int number = 1000;
            long longNumber = 1000;
            double doubleNumber = 1000D;
            float floatNumber = 1000F;


            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            var data = 1000L;

            var val = "chandan";

            var str = "";
            //str = 10;

            object obj = "";
            obj = 10;
            obj = 'C';
            obj = 20L;

            Console.WriteLine("Type of obj variable is =>" + obj.GetType());
            Console.WriteLine("Type of Program Class is => " + typeof(Program));

            Console.WriteLine("Name of the obj variable is => " + nameof(obj));
            Console.WriteLine("Name of the function is => " + nameof(DataTypeRepresentation));
            Console.WriteLine("Name of the program class is => " + nameof(Program));

            var objName = nameof(obj); //objname ="obj"
            var funcName=nameof(DataTypeRepresentation);
            var programType=typeof(Program).ToString();

        }

        static void CastingExample()
        {
            //implicit casting
            int i = 10;
            long j = i;
            float k = j;
            double l = k;


            //explicit casting
            double a = 20.05;
            float b = (float)a;
            long c = (long)b;
            int d = (int)c;


            //type conversion 
            string str = "10";
            int intstr = Convert.ToInt32(str);


                  }
    }

    
}


