using System;
using System.Text;

namespace TestNamespace;

internal class Program
{
    static void Main(string[] args)
    {
        // jagged array
        int[][] ja = new int[3][];
        ja[0] = new int[] { 1, 2, 3 };
        ja[1] = new int[] { 100, 200 };
        ja[2] = new int[] { 5, 6, 7, 8, 9, 10, 50 };

        Console.WriteLine(ja.GetLength(0));
        Console.WriteLine(ja[0].GetLength(0));
        Console.WriteLine(ja[1].GetLength(0));
        Console.WriteLine(ja[2].GetLength(0));

        Console.WriteLine("\nItems of jagged Array :");

        foreach (int[] a in ja)
        {
            foreach(int item in a)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }



        string[,][] jaggedArray = new string[2, 3][];

        jaggedArray[0, 0] = new string[] { "[0,0][0]", "[0,0][1]", "[0,0][2]" };
        jaggedArray[0, 1] = new string[] { "[0,1][0]", "[0,1][1]" };
        jaggedArray[0, 2] = new string[] { "[0,2][0]", "[0,2][1]", "[0,2][2]", "[0,2][3]" };
        jaggedArray[1, 0] = new string[] { "[1,0][0]" };
        jaggedArray[1, 1] = new string[] { "[1,1][0]", "[1,1][1]" };
        jaggedArray[1, 2] = new string[] { "[1,2][0]" };

        Console.WriteLine("\nItems of string jaggedArray is:");
        foreach (string[] array in jaggedArray)
        {
            foreach(string item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

        }

        Console.WriteLine("\nNow Accessing jaggedArray items using index number\n");

        for(int i = 0; i < jaggedArray.GetLength(0); i++)
        {
            for(int j = 0; j  < jaggedArray.GetLength(1); j++)
            {
                for (int k = 0; k < jaggedArray[i, j].GetLength(0); k++)
                    Console.Write($"{jaggedArray[i, j][k]} ");
                Console.WriteLine();
            }
        }

        Console.WriteLine("\nPress any key to Exit");
        Console.ReadKey();
    }
}
