using System;

class Problem12
{
	public static void Main()
	{
		int triangleNum = 0, numDivisor = 0;

		for (int i = 1 ; numDivisor <= 500 ; i++)
		{
			numDivisor = 0;
			triangleNum += i;
			for (int j = 1; j <= Math.Sqrt(triangleNum) ; j++)
			{
				if (triangleNum % j == 0)
					numDivisor += 2;
			}
			if ( (int) Math.Sqrt(triangleNum) * Math.Sqrt(triangleNum) == triangleNum )
					numDivisor--;
		}

		Console.WriteLine(triangleNum);
	}
}
