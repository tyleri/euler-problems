using System;

class problem6
{
	public static void Main()
	{
		int squareSum = 0, sumSquare = 0;

		for (int i = 1; i <= 100; i++)
			squareSum += i;
		squareSum = squareSum * squareSum;

		for (int j = 1; j <= 100; j++)
			sumSquare += j * j;

		Console.WriteLine(squareSum - sumSquare);
	}
}

