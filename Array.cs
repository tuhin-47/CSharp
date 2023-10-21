//C# Array Practice
using System;

namespace ArrayPractice{
    class Solution{
        public void exercise01(){
            //int[] intArray = new int[5];
            int[] intArray = {100,200,300,400,500,600,700,800,900,1000};
            foreach(int item in intArray)
                Console.WriteLine(item);
        }

        public void exercise02(){
            // string[] stringArray = new string[5];
            // stringArray[0] = "One";
            // stringArray[1] = "Two";
            // stringArray[2] = "Three";
            // stringArray[3] = "Four";
            // stringArray[4] = "Five";

            // string[] stringArray = {"One","Two"};

            string[] stringArray = new string[] {"One","Two","One"};

            foreach(string item in stringArray){
                 Console.WriteLine(item);
            }
            Console.WriteLine(string.Join(", ",stringArray));
            Array.Sort(stringArray);
            Console.WriteLine(string.Join(", ",stringArray));
            Array.Reverse(stringArray);
            Console.WriteLine(string.Join(", ",stringArray));
        }
        
        public void exercise03(){
            // decimal[] dArray = new decimal[] {1000,2000,3000,40000,5000};
            decimal[] dArray = {1000,2000,3000,4000,5000};
            foreach(decimal item in dArray)
                Console.WriteLine(item);
        }

        public void exercise04(){
            //2d array
            string[,] twoD = new string[2,3] {
                                        {"0,0" , "0,1","0,2"},
                                        {"1,0", "1,1", "1,2"}
                                    };

            foreach(string item in twoD){
                Console.WriteLine(item+" loop");

            }

            int[,] int2D = new int[2,3] { {100,200,300},{300,200,100}};
            foreach(int item in int2D)
                Console.WriteLine(item);

        }
    }




    class MainClass{
        public static void Main(string[] args){
            Solution solution = new Solution();

            //solution.exercise01();
            //  solution.exercise02();
            // solution.exercise03();
            solution.exercise04();


        }
    }
}
