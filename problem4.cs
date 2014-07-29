using System;

class problem4
{
	public static void Main()
	{
		int i = 999, j = 999;
		for (; i > 99; i--)
			for (; j > 99; j--)
				if (testPalin(i*j))
						{
						Console.WriteLine(i*j);
						return;
						}
	}

	public static bool testPalin(int num)
	{
		int testnum = num;
		int[] array = new int[testnum.ToString().Length];
		for (int n = 0; n < array.Length; n++)
		{
			array[n] = testnum % 10;
			testnum /= 10;
		}

		for (int k = 0; k < array.Length; k++)
			if (array[k] != array[array.Length-k-1])
				return false;
		return true;
	}
}
