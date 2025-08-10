using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit318_assignment2_11357610
{
    internal class Program2
    {

        interface IMoveable
        {
            void Move();

        }

        class Car : IMoveable
        {
            public void Move()
            {
                Console.WriteLine("Car is moving");
            }

        }

        class Bicycle : IMoveable
        {
            public void Move()
            {
                Console.WriteLine("Bicycle is moving");
            }

        }

        public static void Main(string[] args)
        { 
            Car Toyata = new Car();
            Toyata.Move();

            Bicycle Vitus = new Bicycle();
            Vitus.Move();
        }
        
    }
}         

 
  


