//open close principle
using System;
using System.Collections.Generic;

interface ICourse{
    void msg();
}

class Course : ICourse{
    private string courseTitle;
   
    public void msg(){
        Console.WriteLine(courseTitle);
    }

    //constructor
     public Course(string title){
        courseTitle = title;
    }
}

class MainClass{
    public static void Main(string[] args){
        List<ICourse> courseList = new List<ICourse>();
        courseList.Add(new Course("C"));
        courseList.Add(new Course("C++"));
        courseList.Add(new Course("Java"));
        courseList.Add(new Course("Python"));
        courseList.Add(new Course("C#"));

        for(int i = 0; i < courseList.Count; i++)
            courseList[i].msg();
    }
}
