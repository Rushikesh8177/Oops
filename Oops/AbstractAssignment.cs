using Oops;
using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    public abstract class shape
    {
        // method 
        public abstract double CalculateArea();


        //non ab method
        public virtual void Display()
        {
            Console.WriteLine("This is a shape");
        }
    }

    public class Rectangle : shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle (double length , double width)
        {
            Length = length;
            Width = width;

        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override void Display()
        {
            Console.WriteLine("This is the Rectanglr ");
        }
    }

    public class Cricle : shape
    {
        public double Radius { get; set; }

        public Cricle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            Console.WriteLine("This is Cricle");

        }

    }


    internal class AbstractAssignment
    {
        static void Main(string[] args)
        {
            shape rectangle = new Rectangle(10.5, 5.5);
            rectangle.Display();
            //rectangle.CalculateArea();
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());

            Console.WriteLine();

            shape cricle = new Cricle(3.2);
            cricle.Display();
            //cricle.CalculateArea();
            Console.WriteLine("Rectangle Area: " + rectangle.CalculateArea());

            Console.ReadLine();
        }
    }
}
