using System;
using System.ComponentModel.DataAnnotations;

namespace TestNamespace;

class Person
{
    public string name;
    public int age = 10;
    public Person() => Console.WriteLine("Person() Constructor without any parameter");
    public Person(string name, int age) : this()
    {
        this.name = name;
        this.age = age;
        Console.WriteLine("Person.Person() Constructor Executed");
    }
    public void Deconstruct(out string name, out int age)
    {
        name = this.name;
        age = this.age;
    }
    
}

class Program
{
    static void Main()
    {
        Person p = new Person("hello", 100);
        Console.WriteLine(p.name);
        Console.WriteLine(p.age);

        var (name, age) = p;

        Console.WriteLine($"with help of Deconstruct | name : {name}, age : {age}");

        name = "something else";

        Console.WriteLine(p.name);
        Console.WriteLine(name);
        /*  string localMethodWillAccessThis = "parent methods variable";

          localMethod();
          localMethod();

          Console.WriteLine("\nAccessing from parent method\n");
          Console.WriteLine(localMethodWillAccessThis);

          void localMethod()
          {
              Console.WriteLine(localMethodWillAccessThis);
              localMethodWillAccessThis = "changed insided localMethod()";
          }*/
    }
}
