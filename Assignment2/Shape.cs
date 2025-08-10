using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit318_assignment2_11357610.Assignment2
{
    internal class Shapes
    {
        public abstract class Shape()
        {
            abstract public int GetArea();
        }

        public class Circle(int radius) : Shape
        {
            private int Radius = radius;

            public override int GetArea()
            {
                return Radius * Radius;
            }

        }

        public class Rectangle : Shape
        {
            public int Width { get; init; }
            public int Height { get; init; }

            public override int GetArea()
            {
                return Width * Height;
            }
        }

    }
}
