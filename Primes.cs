using System;

class Primes
{
	public static bool IsPrime(int num)
	{
		if (num == 2 || num == 3)
			return true;
		else if (num < 2 || num % 2 == 0)
			return false;
		for (int i = 3; i <= Math.Sqrt(num); i += 2)
			if (num % i == 0)
				return false;
		return true;
	}

	public static int NextPrime(int prime)
	{
		int nextPrime = prime + 1;
		while ( !IsPrime(nextPrime) )
			nextPrime++;
		return nextPrime;
	}

	public static double NextPrime(double prime)
	{
		int roundedPrime = (int) Math.Floor(prime);
		int nextPrime = NextPrime(roundedPrime);
		return (double) nextPrime;
	}

	public static int LastPrime(int prime)
	{
		int lastPrime = prime - 1;
		while ( !IsPrime(lastPrime) )
			lastPrime--;
		return lastPrime;
	}

	public static double LastPrime(double prime)
	{
		int roundedPrime = (int) Math.Ceiling(prime);
		int lastPrime = LastPrime(roundedPrime);
		return (double) lastPrime;
	}

	public static int LargestPrimeFactor(long num)
	{
		for (long i = 2 ; i < Math.Sqrt(num) ; i++)
			while (num % i == 0)
				num /= i;
		
		return (int) num;
	}
}
