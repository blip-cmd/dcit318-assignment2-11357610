namespace Assignment2;
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

//class Program
//{
//    static void Main(string[] args)
//    {
//        new Animal().MakeSound();   // I'm a goat, i'm a goat, merhhh...
//        new Dog().MakeSound();      // Bark
//        new Cat().MakeSound();      // Meow
//    }
//}
