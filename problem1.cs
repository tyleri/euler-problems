using System;

class problem1
{
	public static void Main()
	{
		int total = 0;
		for (int i = 3; i < 1000; i++)
		{
			if (i % 5 == 0 || i % 3 == 0)
				total += i;
		}
		Console.WriteLine(total);
	}
}
