// interface
using System;

namespace TestNameSpace
{
    interface IAnimal {
        void sound();
    }

    class Pig : IAnimal { 
        public void sound()
        {
            Console.WriteLine("Pig Sound");
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

            Console.WriteLine("Using Pig Class");
            pig.sound();
           
            Console.WriteLine("Using Dog Class");
            dog.sound();
            

            Console.ReadKey();
        }
    }
}
