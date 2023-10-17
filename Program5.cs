//multiple inheritance 
using System;

namespace TestNameSpace
{
    interface IAnimal {
        void sound();
    }
    
    interface IFly
    {
        void fly();
    }

    class Bird : IAnimal, IFly { 
        public void sound()
        {
            Console.WriteLine("Bird Sound");
        }

        public void fly()
        {
            Console.WriteLine("Bird Fly");
        }
    }
    class Pig : IAnimal,IFly { 
        public void sound()
        {
            Console.WriteLine("Pig Sound");
        }
        public void fly()
        {
            Console.WriteLine("Pig Can not Fly");
        }
    }

    class Dog : IAnimal
    {
        public void sound()
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
            Bird bird = new Bird();

            bird.sound();
            bird.fly();

            
            pig.sound();
            pig.fly();

            
            dog.sound();
            

            Console.ReadKey();
        }
    }
}
