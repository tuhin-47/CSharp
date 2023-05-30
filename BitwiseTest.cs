using System;

internal class BitwiseTest{
    public static void Main(){
        byte a = Convert.ToByte(100);
        byte b = Convert.ToByte(200);
        byte c = Convert.ToByte( a & b);
        Console.WriteLine(" a & b = {0}",c);
    }
}