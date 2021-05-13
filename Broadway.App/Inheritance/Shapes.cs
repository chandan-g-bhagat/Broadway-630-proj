using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App.Inheritance
{
    public interface IArea
    {
        void Area();
    }

    public interface IPerimeter
    {
        void Perimeter();
       
    }
    public interface IDisplay
    {
        void Display();
    }
    public interface IShape : IArea, IPerimeter
    {
        void GetInput();
       
    }

    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public void GetInput()
        {
            
            Console.WriteLine("Enter Length: ");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Breadth: ");
            Breadth = Convert.ToDouble(Console.ReadLine());
        }
        public void Area()
        {
            Console.WriteLine("Area = " + Length * Breadth);
        }
        public void Perimeter()
        {
            Console.WriteLine("Perimeter = " + 2*(Length + Breadth));
        }
        private void SomeFunction()
        {
            Console.WriteLine("I am from SomeFunction defined in Rectangle Class");
            
        }
    }

    public class Square : IShape
    {
        public double Length { get; set; }
        public void GetInput()
        {
            Console.WriteLine("Enter Length: ");
            Length = Convert.ToDouble(Console.ReadLine());
          
        }
        public void Area()
        {
            Console.WriteLine("Area = " + Math.Pow(Length,2));
        }
        public void Perimeter()
        {
            Console.WriteLine("Perimeter = " + 4 * Length );
            OtherFunction();
        }
        private void OtherFunction()
        {
            Console.WriteLine("I am from OtherFunction defined in Square Class");
        }
    }

    public class Circle : IShape
    {
        const double Pi = 3.14;
        public double Radius { get; set; }

        public void Area()
        {
            Console.WriteLine("Area => " + Pi * Radius * Radius);
        }

        public void GetInput()
        {
            Console.WriteLine("Enter Radius");
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            Console.WriteLine("Perimeter => " + 2* Pi * Radius);
        }
    }
}
