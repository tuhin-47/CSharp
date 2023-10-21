// Example of C# get and set
using System;
class Person{
    private string _name;
    public string Name {
        get { return _name; }
        set { _name = value; }
    }
}
class MainClass{
    public static void Main(string[] args){
        Person person = new Person();
        person.Name = "Hasan Mahmud Tuhin";
        Console.WriteLine(person.Name);
    }
}
