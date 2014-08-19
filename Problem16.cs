using System;
using System.Diagnostics;
using System.Numerics;

class Problem16
{
	public static void Main()
	{
		Stopwatch s = Stopwatch.StartNew();
		BigInteger result = BigInteger.Pow(2, 1000);

		int sumDigits = 0;
		while (result > 0)
		{
			sumDigits += (int) (result % 10);
			result /= 10;
		}
		Console.WriteLine(sumDigits);
		s.Stop();
		Console.WriteLine("Time Elapsed: {0}", s.Elapsed);
	}
}
