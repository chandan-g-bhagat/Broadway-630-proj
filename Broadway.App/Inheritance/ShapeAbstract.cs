using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.App.Inheritance
{
    public abstract class ShapeAbstract // no object created  for abstract
    {

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
        public abstract void GetInput();


        public void DisplayArea()
        {
            Console.WriteLine("Area => " + CalculateArea());
        }
        public void DisplayPerimeter()
        {
            Console.WriteLine("Perimeter => " + CalculatePerimeter());
        }

        public void DisplayIntro()
        {
            Console.WriteLine("I am written in abstract class");
        }

    }

    public class RectangleAbstract : ShapeAbstract
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public override double CalculateArea()
        {
            return Length * Breadth;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Length + Breadth);
        }

        public override void GetInput()
        {
            Console.WriteLine("Enter Length: ");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Breadth: ");
            Breadth = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class SquareAbstract : ShapeAbstract
    {
        public double Length { get; set; }

        public override double CalculateArea()
        {
            return Math.Pow(Length,2);
        }

        public override double CalculatePerimeter()
        {
            return 4 * Length;
        }

        public override void GetInput()
        {
            Console.WriteLine("Enter Length: ");
            Length = Convert.ToDouble(Console.ReadLine());
        }
    }

}
