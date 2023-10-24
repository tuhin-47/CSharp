using System;

class TestClass{
    private string _name ;
    public string Name { 
        get {
            Console.WriteLine("Getting Value uisng Getters");
            return _name;
        }
        set {
            Console.WriteLine("Seting value using Setters");
            _name = value;
        }

    }
}

class MainClass{
    public static void Main(string[] args){
        TestClass test = new TestClass();
        test.Name ="TestClass._name";
        Console.WriteLine(test.Name);
    }
}
