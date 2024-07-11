using System;

class Factorial 
{
	public static void Main(String [] args)

	{
		int myNumber, result = 1;
		Console.WriteLine("Input Number: ");
		myNumber = Convert.ToInt32(Console.ReadLine());
		
		for(int i = myNumber; i > 0; i--)
			{
				result = i * result;
			}
		Console.WriteLine("The factorial of " + myNumber + " is " + result);		
	}
	
}