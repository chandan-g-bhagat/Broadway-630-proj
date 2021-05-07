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


            string result = "n";
            do
            {
                //PropertiesExample();

                //ForLoopExample();

                ArrayExxample();

                Console.WriteLine("Do you want to repeat it again (y/n)");
                result = Console.ReadLine();
            }
            while (result.ToUpper() == "Y") ;

            Console.ReadLine();
        }

        static void ArrayExxample()
        {
            //array of int 
            Console.WriteLine("Array of int");
            int max = 5;
            
            int[] i=new int[max];
            //total element 1-5
            //index 0-4
            i[0] = 10;
            i[1] = 20;
            i[2] = 30;
            i[3] = 40;
            i[4] = 50;

            //functions of Array
           // Array.Reverse(i);

            Array.Resize(ref i, i.Length - 1);

            int[] j = new int[5];
          
            //i=>0, j=0
            Array.Copy(i,1, j,0,2);

        }

        static int test()
        {
            return 0;
        }

        static void ForLoopExample()
        {
            Console.WriteLine("Enter the text");
            var str = Console.ReadLine();

            //number i is looped
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
                if (str[i] == 'z')
                {
                    break;
                }
            }

            //continue example
            //int i = 0;
            //while (i < 10)
            //{
            //    if (i == 4)
            //    {
            //        i++;
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////str => test
            //foreach(var item in str)
            //{
            //    Console.WriteLine(item);
            //}

            //int j = 0;
            //while(j< str.Length)
            //{
            //    Console.WriteLine(str[j]);
            //    j++;
            //}



        }


        static void PropertiesExample()
        {
            ScienceSubject science = new ScienceSubject();
            science.MarksObtained = -30;

            Console.WriteLine("Marks in science => " + science.MarksObtained);

            Student s = new Student();
            s.Setnames("Subham", "Koirala");
          
            Console.WriteLine("Student FullName => " + s.FullName);

            Student s1 = new Student();
            s1.Setnames("Saroj", "Koirala");

            Console.WriteLine("Student FullName => " + s1.FullName);





            StudentNew sNew = new StudentNew();
            sNew.FName = "Saroj";
            sNew.LName = "Koirala";

            Console.WriteLine("Student FullName => " + sNew.FName+"."+sNew.LName);

            StudentNew sNew1 = new StudentNew();
            sNew1.FName = "Saroj";
            sNew1.LName = "Koirala";

            Console.WriteLine("Student FullName => " + sNew1.FName + "." + sNew1.LName);


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

        static void BranchingExample()
        {
            Console.WriteLine("Enter a character");
            var data = Console.ReadLine();
            var character = data[0];

            switch(character)
            {
                case 'a':
                case 'A':
                    Console.WriteLine("a is a vowel");
                    break;
                case 'e':
                case 'E':
                    Console.WriteLine("e is a vowel");
                    break;
                case 'i':
                case 'I':
                    Console.WriteLine("i is a vowel");
                    break;
                case 'o':
                case 'O':
                    Console.WriteLine("o is a vowel");
                    break;


                default:
                    break;
            }
        }
    }


}


