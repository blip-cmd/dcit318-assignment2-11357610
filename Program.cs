
using System;
//using System.Drawing;
using static dcit318_assignment2_11357610.Assignment2.Animals;
using static dcit318_assignment2_11357610.Assignment2.Shapes;
using static dcit318_assignment2_11357610.Assignment2.Vehicles;


namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Animal Sounds ===");
            new Animal().MakeSound();
            new Dog().MakeSound();
            new Cat().MakeSound();

            Console.WriteLine("\n=== Shape Areas ===");
            Circle circle = new Circle(5);
            Console.WriteLine($"Circle covers {circle.GetArea()} meter squared");
            //new Circle(5).GetArea();

            Rectangle rectangle = new Rectangle { Width = 7, Height = 2 };
            Console.WriteLine($"Rectangle covers {rectangle.GetArea()} meter squared");

            Console.WriteLine("\n=== Vehicle Movement ===");
            Car toyota = new();
            toyota.Move();

            Bicycle vitus = new Bicycle();
            vitus.Move();
        }
    }
}