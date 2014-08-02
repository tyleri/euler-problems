using System;

class Problem3
{
	public static void Main()
	{
		double largest = 600851475143;
		
		for (int i = 2 ; i < largest ; i++)
			while (largest % i == 0)
				largest /= i;
		
		Console.WriteLine(largest);
	}
}
