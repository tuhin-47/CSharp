namespace TestNameSpace
{
    class AnotherClass { 
        public void greeting()
        {
            Console.WriteLine("\nGreetings from AnotherClass");
        }
    }
    class Car
    {
        private string carName;
        //using properties to access this
/*        public string CarName
        {
            get { return carName; }
            set { carName = value; }
        }*/
        
        //shorter version of properties
        public string CarName { get; set; }
       public Car(string name="Toyota CHR")
        {
            carName = name;
            Console.WriteLine("[Constructor]carName = "+name);
        }
    }
    class Animal
    {
        public void sound()
        {
            Console.WriteLine("Animal Sound.");
        }
    }
    class Pig : Animal
    {
        public void sound()
        {
            Console.WriteLine("Pig Sound");
        }
    }
    class Dog : Animal
    {
        public void sound()
        {
            Console.WriteLine("Dog Sound");
        }
    }

    class TestClass
    {
        public void test()
        {
            Console.WriteLine("This is from TestClass object");
        }
        public static void Main(string[] args)
        {

            /**string firstName = "Hasan ";
            string lastName = "Mahmud";
            string fullName = string.Concat(firstName, lastName);

            Console.WriteLine(fullName);
            for (int i = 0; i < fullName.Length; i++)
            {
                Console.WriteLine(fullName[i]);
            }

            int x = 5, y = 6;
            Console.WriteLine(x > y);*/

            /*int x = 5, y = 6;

            string ans = x > y ? "x is bigger" : "x is smaller";*/

            /*string[] cars;
            cars  = new string[] { "Car 2", "Car 1", "Car 3", "Car 4", "Car 5", "Car 6", "Car 7", "Car 8" };
            
            foreach(string car in cars) Console.Write(car+" | ");
            Console.WriteLine();
            Array.Sort(cars);

            foreach(var car in cars)
            {
                Console.Write(car+" | ");
            }
            Console.WriteLine();

            Console.WriteLine("cars.Max() :  "+cars.Max());
            Console.WriteLine("cars.Min() : "+cars.Min());
            Console.WriteLine("cars.Sum() : "+cars.Sum());*/

            /*string[,] twoD = { { "One", "Two"  }, { "Three", "Four" } };
            
            for(int i = 0; i < twoD.GetLength(0); i++)
            {
                for(int j = 0; j < twoD.GetLength(1); j++)
                {
                    Console.Write(twoD[i,j]+" ");
                }
                Console.WriteLine();
            }
*/


            /*AnotherClass anotherClass = new AnotherClass();
            anotherClass.greeting();

            TestClass testClass = new TestClass();
            testClass.test();

            Car car = new Car();*/

            /*Car car = new Car();
            Console.WriteLine("car.CarName before setters : "+car.CarName);
            car.CarName = "carName Changed to This Value";
            Console.WriteLine(car.CarName);*/

            Animal animal = new Animal();
            Animal pig = new Pig();
            Animal dog = new Dog();

            animal.sound();
            pig.sound();
            dog.sound();

            Console.ReadKey();
        }
    }
}
