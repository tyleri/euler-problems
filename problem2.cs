using System;

class Problem2
{
	public static void Main()
	{
		int sum = 0;
		for (int i = 1; ; i++)
		{
			if (fib(i) > 4000000)
				break;
			if (fib(i) % 2 == 0)
				sum += fib(i);
		}
		Console.WriteLine(sum);
	}

	public static int fib(int n)
	{
		if (n == 1)
			return 1;
		else if (n == 2)
			return 2;
		else
			return fib(n-1)+fib(n-2);
	}
}
