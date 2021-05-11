using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App
{
    public class Human
    {
        //Constructor : runs onetime throughout the object lifecycle
        public Human()
        {
            //e = 1.7;
            //pi = 1.14; //not valid
        }
        //variable
        public int j = 10;
        const double pi = 3.14;
        readonly double e = 2.7;
        //properties
        public int number { get; set; } // properties

        int _numberProp;
        public int NumberProp
        {
            get { return _numberProp; }
            set { _numberProp = value; }
        }

        

        //methods or functions
        void SomeFunctiuon()
        {
            //pi = 2.14;
            //e = 3.7;
        }
       //GC handles all the things, instead we use IDispossable

    }




    public class ScienceSubject
    {
        //variable
        public readonly int fullMarks=20;
        public readonly int minMarks=10;
        private int marksObtained=-30;

        public int MarksObtained
        {
            get { return marksObtained; }
            set
            {
                if (value<= minMarks)
                {
                    marksObtained = minMarks;
                }
                else if (value>=fullMarks)
                {
                    marksObtained = minMarks;
                }
                else
                {
                    marksObtained = minMarks;
                }
                
                
                // Alternatives of if...else 

                //if (value <= minMarks)
                //    marksObtained = minMarks;
                //else if (value >= fullMarks)
                //    marksObtained = fullMarks;
                //else
                //    marksObtained = value;


                //// (condition)? true statement : false statement 
                //marksObtained = (value <= minMarks) ? minMarks : (value >= fullMarks) ? fullMarks : value;

            }
        }

        public ScienceSubject()
        {
            
        }

        public void Test(int a)
        {
            if (a==10)
            {
                Console.WriteLine("The value is 10");
                return;
            }
            else
            {
                Console.WriteLine("Value is not 10");
            }

            Console.WriteLine("Executed Function");
        }
    }


    public class Student
    {
        private string FName = "";

        private string LName = "";

        public string FullName
        {
            get
            {
                return FName + "." + LName;
            }
        }

        public void Setnames(string firstName, string lastName)
        {
            FName = firstName;
            LName = lastName;
        }
    }

    public class StudentNew
    {
        public string FName = "";
        public string LName = "";
        
    }
}
