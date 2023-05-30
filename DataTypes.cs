using System;

namespace DemoNameSpace{
    internal class TestClass{
        string name{get;set;}
    }
    internal class DemoClass{
        public static void Main(){
            Console.WriteLine("sizeof(bool) : {0} Bytes",sizeof(bool));
            // in CSharp byte mane unsigned byte
            //           sbyte mane signed byte.
            // so sbyte range is -128 to 127
            //    byte range is 0 to 255
            Console.WriteLine("sizeof(byte) : {0} Bytes",sizeof(byte));
            Console.WriteLine("sizeof(sbyte) : {0} Bytes",sizeof(sbyte));
            // short mane singned short  -32768 to 32767
            // ushort mane unsinged short 0 to 65535
            Console.WriteLine("sizeof(short) : {0} Bytes",sizeof(short));
            Console.WriteLine("sizeof(ushort) : {0} Bytes",sizeof(ushort));
            Console.WriteLine("sizeof(char) : {0} Bytes",sizeof(char));
            Console.WriteLine("sizeof(int) : {0} Bytes",sizeof(int));
            Console.WriteLine("sizeof(uint) : {0} Bytes",sizeof(uint));
            Console.WriteLine("sizeof(long) : {0} Bytes",sizeof(long));
            Console.WriteLine("sizeof(ulong) : {0} Bytes",sizeof(ulong));
            Console.WriteLine("sizeof(float) : {0} Bytes",sizeof(float));
            Console.WriteLine("sizeof(double) : {0} Bytes",sizeof(double));
			
            // decimal is more useful for monetary calculation
            Console.WriteLine("sizeof(decimal) : {0} Bytes",sizeof(decimal));
            
        }
    }
}