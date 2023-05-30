using System;

namespace Demo{
    internal class DemoClass{
        public static void Main(string[] args){
            {
                // context 1;
                string name="context 1";
                Console.WriteLine(name);
            }
            {
                // context 2
                int name = 1000;
                Console.WriteLine("context 2 : {0}",name);
            }
        }
    }
}