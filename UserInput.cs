using System;

internal class PrimeNumber{
	
	protected bool testPrime(int number){
		if(number == 1)
			return false;
		
		for(int i = 2; i < number; i++)
			if(number % i == 0)
				return false;
		
		return true;
	}
	
	protected i=nt recursiveFactorial(int number){
		if( n  <= 1)
			return 1;
		else
			return n * recursiveFactorial( n - 1);
	}
	
	
	public static void Main(string[] args){
		Console.WriteLine("Enter a Number to Test Prime :");
		string input = Console.ReadLine();
		int number   = Convert.ToInt32(input);
		
		if(testPrime(number))
			Console.WriteLine("{0} is Prime Number",number);
		else
			Console.WriteLine("{0} is Not Prime Number",number);
		
		Console.WriteLine("Enter a Number to find Factorial :");
		input = Console.ReadLine();
		number = Convert.ToInt32(input);
		Console.WriteLine("Factorial of {0} is : {1}",number,recursiveFactorial(number));
	}
	
	
}