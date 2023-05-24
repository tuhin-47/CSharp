/*
Sample Output:
--------------
	X = 0
	Y = 0

	X = 50
	Y = 100

	Pair Contents :-
	 First : 1000
	 Second : Paired Item
*/

using System;

namespace OnlineCompiler{
    class OnlineTestClass{
        public static void Main(string[] args){
            var point1 = new Point(0,0);
            var point2 = new Point(50,100);
            point1.show();
            point2.show();
            
            //--- Using Generic Type Creating a Constructed Type
            
            var pair = new Pair<int,string>(1000,"Paired Item");
            pair.showContent();
        }
    }
    
    public class Point{
        public int X;
        public int Y;
        
        public Point(int x, int y){
            X = x;
            Y = y;
        }
        public void show(){
           Console.WriteLine("X = {0}\nY = {1}\n",X,Y);
        }
    }
    
    // Generic Class
    class Pair<TFirst, TSecond>{
        public TFirst First;
        public TSecond Second;
        
        public Pair(TFirst first, TSecond second) => (First,Second) = (first, second);
        
        public void showContent(){
            Console.WriteLine("Pair Contents :-\n First : {0}\n Second : {1}",First,Second);
        }
    }
}
