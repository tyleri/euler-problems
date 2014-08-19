using System;
using System.Diagnostics;
using System.Numerics;

class Problem25
{
	public static void Main()
	{
		BigInteger bigInt1 = BigInteger.One, bigInt2 = BigInteger.One, temp;
		while (bigInt2.ToString().Length < 1000)
		{
			temp = bigInt1 + bigInt2;
			bigInt1 = bigInt2;
			bigInt2 = temp;
		}
		Console.WriteLine(bigInt2);
	}

	static BigInteger Fib(BigInteger num)
	{
		return
			(num == BigInteger.One) ? BigInteger.One
			: (num == new BigInteger(2)) ? BigInteger.One
			: Fib(num - 1) + Fib(num - 2);
	}
}
