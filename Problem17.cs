using System;

class Problem17
{
	public static void Main()
	{
		Console.WriteLine(Convert.ToString(123456789).Length);
	}

	static int GetLength(int number)
	{
		switch (number)
		{
			case 1:
			case 2:
			case 6:
				return 3;
			case 4:
			case 5:
			case 9:
				return 4;
			case 3:
				return 5;
			case 7:
				return 5;
			case 8:
				return 5;
			default:
				return 0;
		}
	}

	static int[] SplitNumber(int number)
	{
		int[] numArray = new int[number.ToString().Length];
		for (int count = 0; number > 0; count++)
		{
			numArray[count] = number / 10;
			number %= 10;
		}
		
		return numArray;
	}
}
