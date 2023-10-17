using System;

namespace TestNameSpace
{
    abstract class Animal
    {
        public abstract void sound();

        public void run()
        {
            Console.WriteLine("Animal Running.");
        }
    }

    class Pig : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Pig Sound");
        }
    }

    class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog Sound");
        }
    }


    class TestClass
    {
        public static void Main(string[] args)
        {
            Pig pig = new Pig();
            Dog dog = new Dog();

            Console.WriteLine("Using Pig Class");
            pig.sound();
            pig.run();

            Console.WriteLine("Using Dog Class");
            dog.sound();
            dog.run();

            Console.ReadKey();
        }
    }
}
