//more array practice
using System;
namespace MoreArrayPractice{

    class ArrayPractice{
        public void exercise01(){
            Console.WriteLine("Jugged Array");
            int[][] jaggedArray = new int[2][];
            jaggedArray[0] = new int[10] {1,2,3,4,5,6,7,8,9,10};
            jaggedArray[1] = new int[2] {100,200};
            
            for(int i = 0; i < jaggedArray.GetLength(0); i++){
                for(int j = 0; j < jaggedArray[i].GetLength(0); j++)
                    if( j == jaggedArray[i].GetLength(0) - 1 )
                        Console.WriteLine(jaggedArray[i][j]);
                    else
                        Console.Write(jaggedArray[i][j]+", ");
            }

        }
    }





    class MainClass{
        public static void Main(string[] args){
            ArrayPractice arrayPractice = new ArrayPractice();

            arrayPractice.exercise01();
        }
    }
}
