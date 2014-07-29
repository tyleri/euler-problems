using System;

class problem5
{
	public static void Main()
	{
		int n = 20;
		bool isDivisible = false;
		while (!isDivisible)
		{
			n += 20;
			for (int i = 3; i < 20; i++)
			{
				if (n % i > 0)
					break;
				else if (i == 19)
					isDivisible = true;
			}
		}
		Console.WriteLine(n);
	}
}
