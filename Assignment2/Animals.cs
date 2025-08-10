using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dcit318_assignment2_11357610.Assignment2
{
    internal class Animals
    {
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("I'm a goat, i'm a goat, merhhh...");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow");
            }
        }

    }
}
