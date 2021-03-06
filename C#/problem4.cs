using System;

class Problem4
{
	public static void Main()
	{
		int largest = 0;
		for (int i = 100; i < 1000; i++)
			for (int j = 100; j < 1000; j++)
				if (testPalin(i*j) && (i*j > largest))
					largest = i*j;
		Console.WriteLine(largest);
	}

	public static bool testPalin(int num)
	{
		int[] array = new int[num.ToString().Length];
		for (int n = 0; n < array.Length; n++)
		{
			array[n] = num % 10;
			num /= 10;
		}

		for (int k = 0; k < array.Length; k++)
			if (array[k] != array[array.Length-k-1])
				return false;
		return true;
	}
}
