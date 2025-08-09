using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit318_assignment2_11357610
{
    internal class Program1
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Console.WriteLine($"Circle covers {circle.GetArea()} meter squared");

            Rectangle rectangle = new Rectangle { Width = 7, Height = 2 };
            Console.WriteLine($"Rectangle covers {rectangle.GetArea()} meter squared");
        }
        abstract class Shape()
        {
            abstract public int GetArea();
        }

        class Circle : Shape
        {
            private int Radius;

            public Circle(int radius)
            {
                Radius = radius;
            }

            public override int GetArea()
            {
                return Radius * Radius;
            } 

        }

        class Rectangle : Shape
        {
            public int Width { get; init; }
            public int Height {get; init; }

            public override int GetArea()
            {
                return Width * Height;
            }
        }
    }         

    }
  


