using System;

class Problem10
{
	public static void Main()
	{
		double sum = 0;

		for (int i = 2; i < 2000000; i++)
			if (isPrime(i))
				sum += i;

		Console.WriteLine(sum);
	}

	public static bool isPrime(int num)
	{
		if (num == 2 || num == 3)
			return true;
		for (int i = 2; i <= num / 2; i++)
			if (num % i == 0)
				return false;
		return true;
	}
}

