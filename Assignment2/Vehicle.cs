using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit318_assignment2_11357610.Assignment2
{
    internal class Vehicles
    {
        public interface IMoveable
        {
            void Move();

        }

        public class Car : IMoveable
        {
            public void Move()
            {
                Console.WriteLine("Car is moving");
            }

        }

        public class Bicycle : IMoveable
        {
            public void Move()
            {
                Console.WriteLine("Bicycle is moving");
            }

        }

    }
}
