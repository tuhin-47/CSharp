// C# List Practice
using System;
using System.Collections.Generic;
namespace ListPractice{
    class ListPractice{
        public void exercise01(){
            List<int> listItem = new List<int>();
            listItem.Add(500000);
            listItem.Add(100);


            for(int i = 0; i < listItem.Count; i++)
                Console.WriteLine(listItem[i]);
         
        }
    }

    class MainClass{
        public static void Main(string[] args){
            ListPractice listPractice = new ListPractice();
            listPractice.exercise01();

        }
    }
}
