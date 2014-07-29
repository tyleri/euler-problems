using System;

class problem4
{
	public static void Main()
	{
		int i = 999, j = 999;
		while (i > 99)
			while (j > 99)
				if (testPalin(i*j)
						{
						Console.WriteLine(i*j);
						return;
						}
	}

	public static bool testPalin(num)
	{
		int[] array = new int[num.ToString().Length];
		for (int n = 0; n < array.Length; n++)
		{
			array[n] = num % 10;
			num /= 10;
		}

		if (array.equals(Array.Reverse(array))
			return true;
		else
			return false;
}
