using System;
using System.Diagnostics;

class Problem3
{
	public static void Main()
	{
		Stopwatch s = Stopwatch.StartNew();
		long largest = 600851475143;
		largest = Primes.LargestPrimeFactor(largest);
		Console.WriteLine(largest);
		s.Stop();
		Console.WriteLine("Elapsed Time: {0}", s.Elapsed);
	}
}
