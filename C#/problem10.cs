using System;
using System.Diagnostics;

class Problem10
{
	public static void Main()
	{
		Stopwatch s = Stopwatch.StartNew();
		double sum = 0;

		for (int i = 0; i < 2000000; i = Primes.NextPrime(i))
			sum += i;

		Console.WriteLine(sum);
		s.Stop();
		Console.WriteLine("Elapsed Time: {0}", s.Elapsed);
	}
}

