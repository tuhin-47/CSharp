//just putting something here.

using System;

namespace PracticeNameSpace
{
    internal class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking for CommandLine Arguments : \n");
            if (args.Length > 0)
            {
                foreach(string arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
            else
            {
                Console.WriteLine("No CommandLine Argument Provided here");
            }

            Console.ReadKey();
        }
    }
}
