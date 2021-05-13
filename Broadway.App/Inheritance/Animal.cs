using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App.Inheritance
{
    public class LivingThing
    {
        public LivingThing()
        {

        }

        public LivingThing(string Name)
        {

        }

        protected string LivingThingName = "";
        private string privateLivingThingName = "";
        public string publicLivingThingName = "";

        public virtual void PolyFunction()
        {
            Console.WriteLine("I am from LivingThing class");
        }
    }
    public class Animal : LivingThing
    {
        public Animal():base()
        {

        }

        public Animal(string Name): base(Name)
        {

        }
        public string publicName = "";
        protected string protectedName = "";
        private string privateName = "";

        public void Test()
        {
            
        }

        public override void PolyFunction()
        {
            Console.WriteLine("I am from animal class");
        }
    }
    public class Vertibrate : Animal
    {
        public Vertibrate() :base()
        {

        }

        public Vertibrate (string Name): base(Name)
        {

        }

        public string VertibratePublicName = "";
        public void Test()
        {
            publicName = "";
            protectedName = "";
            LivingThingName = "";
            
            //privateName = ""; //not inherited
           
        }

        public override void PolyFunction()
        {
            Console.WriteLine("I am from Vertibrate class");
        }
    }


    public class Plant: LivingThing
    {

    }
}
