using Broadway.App.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClass;
namespace Broadway.App
{
    class Program
    {
        static void Main(string[] args)
        {
            #region arguments demo, Uncomment to use it

            //if (args.Length>0)
            //{
            //    if (args.Contains("--dev"))
            //    {
            //        Console.WriteLine("Developer mode enabled");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Enter Password");
            //    Console.ReadLine();
            //}

            #endregion


            #region basic things

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

            #endregion

            string result = "n";
            do
            {
                //PropertiesExample();

                //ForLoopExample();

                //ArrayExxample();

                //FunctionExecutionExample();

                //OperatorOverloadingExample();

                //StaticAndNonStaticExample();

                //InheritanceExample();

                //PolymorphismExample();

                //InertfaceExample();
                
                AbstractExample();

                Console.WriteLine("Do you want to repeat it again (y/n)");
                result = Console.ReadLine();
            }
            while (result.ToUpper() == "Y") ;

            Console.ReadLine();
           
        }

        static ShapeAbstract shapeAbs; //null
        static void AbstractExample()
        {
            Console.WriteLine("1 for Rectangle\n2 for Square");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    shapeAbs = new RectangleAbstract();
                    break;
                case "2":
                    shapeAbs = new SquareAbstract();
                    break;
                case "3":
                    //shape = new Circle();
                    break;
                default:
                    break;
            }
            shapeAbs.DisplayIntro();

            shapeAbs.GetInput();
            shapeAbs.DisplayArea();
            shapeAbs.DisplayPerimeter();
        }


        static IShape shape;
        public static void InertfaceExample()
        {
            Console.WriteLine("1 for Rectangle\n2 for Square\n3 for Circle");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    shape = new Rectangle();
                    break;
                case "2":
                    shape = new Square();
                    break;
                case "3":
                    shape = new Circle();
                    break;
                default:
                    break;
            }
            shape.GetInput();
            shape.Area();
            shape.Perimeter();

        }

        static void PolymorphismExample()
        {
            LivingThing livingObj = new LivingThing();
            livingObj.PolyFunction();

            LivingThing animalObj = new Animal();
            animalObj.PolyFunction();

            LivingThing vertibrateObj = new Vertibrate();
            vertibrateObj.PolyFunction();
        }

        static void InheritanceExample()
        {
            var vertibrate = new Vertibrate("Human");

            Console.WriteLine("Type of Vertibrate => " + vertibrate.GetType());
            vertibrate.VertibratePublicName = "";

            var animalV = (Animal)vertibrate;
            animalV.publicName = "";
            animalV.publicLivingThingName = "";

            var livingthingV = (LivingThing)vertibrate;
            livingthingV.publicLivingThingName = "";
            
           // var plant = (Plant)vertibrate;

            var newPlant = new Plant();
            var plantlivingThing = (LivingThing)newPlant;

            var animal = new Animal();
            animal.publicName = "TestpublicName";
            animal.publicLivingThingName = "publicLivingThingName";
            var animallivingThing = (LivingThing)animal;


            LivingThing[] livingThings = new LivingThing[2];
            livingThings[0] = new LivingThing();
            livingThings[1] = new Animal();
            Array.Resize(ref livingThings, livingThings.Length + 2);
            livingThings[2] = new Vertibrate();
            livingThings[3] = new Plant();


            Animal[] animals = new Animal[3];
            animals[0] = new Animal();
            animals[1] = new Vertibrate();
            //animals[2] = new Plant();
           

         }

        static void StaticAndNonStaticExample()
        {
            //var staticObj = new StaticClasss(); //cannot create object
            var nonstaticObj = new NonStaticClass();
            var nonstaticObj1 = new NonStaticClass();
            var nonstaticObj2 = new NonStaticClass();

            //NonStaticClass.j = 30;
            //NonStaticClass.StaticFunctionOne();

            //nonstaticObj.i = 40;
            Console.WriteLine("for nonstaticObj");
            nonstaticObj.FunctionOne();
            
           // nonstaticObj1.i = 41;
            Console.WriteLine("for nonstaticObj1");
            nonstaticObj1.FunctionOne();

            //nonstaticObj2.i = 42;
            Console.WriteLine("for nonstaticObj2");
            nonstaticObj2.FunctionOne();

            //StaticClasss.i = 20;
            //StaticClasss.FunctionOne();

            Class1 obj = new Class1();
            
            
        }

        static void OperatorOverloadingExample()
        {
            int a = 20; int b = 30;
            var res = a + b;

            var aObj = new Arithmetic() { i=35, str="Some "};
            var bobj = new Arithmetic() { i=45, str="String"};
            var resObj = aObj + bobj;
            var resObj1 = aObj + bobj;
            var resObj2 = aObj + bobj;
            var resObj3 = aObj + bobj;
            var resObj4 = aObj + bobj;


            Console.WriteLine("Final i => " + resObj.i);
            Console.WriteLine("Final str => " + resObj.str);

            aObj++;

            Console.WriteLine("Final i => " + aObj.i);
            Console.WriteLine("Final str => " + aObj.str);
            
            
            aObj = new Arithmetic() { i = 35, str = "Some " };
            bobj = new Arithmetic() { i = 35, str = "Some " };

            var cObj = new Arithmetic() { i = aObj.i + bobj.i, str = aObj.str + bobj.str , Price=aObj.Price+bobj.Price};
            var dObj = new Arithmetic() { i = aObj.i + bobj.i, str = aObj.str + bobj.str , Price = aObj.Price + bobj.Price };

            var eObj = new Arithmetic() { i = aObj.i + bobj.i, str = aObj.str + bobj.str , Price = aObj.Price + bobj.Price };

            var result = (aObj == bobj);

            Console.WriteLine("result => " + result); //&& ||
        }

        static void FunctionExecutionExample()
        {
            ScienceSubject ss = new ScienceSubject();
            //ss.Test(10);

            var a = new Arithmetic();

            var b = new Arithmetic(25);
           
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


