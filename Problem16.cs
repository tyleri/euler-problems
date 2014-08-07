using System;
using System.Linq;

class Problem16
{
	public static void Main()
	{
		int[] num = new int[1000];
		num[0] = 1;

		// multiply by 2 1000 times;
		for (int i = 0; i < 1000; i++)
		{
			// Multiplies all digits by two
			MultTwo(num);

			// Fixes place values
			AdjustDigits(num);
		}

		Console.WriteLine(num.Sum());
	}

	static void MultTwo(int[] numArray)
	{
		for (int index = 0; index < numArray.Length; index++)
			numArray[index] *= 2;
	}

	static void AdjustDigits(int[] numArray)
	{
		for (int i = 0; i < 1000; i++)
			if (numArray[i] > 9)
			{
				numArray[i+1] += numArray[i] / 10;
				numArray[i] %= 10;
			}
	}
}
