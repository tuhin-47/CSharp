using System;

struct MainContainer{
    public static void Main(string[] args){
        Console.WriteLine("commands provied to this application:- \n");

        foreach(string arg in args){
            Console.WriteLine(" "+arg);
        }

        Console.WriteLine("\nDone");
    }
}
