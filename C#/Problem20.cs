using System;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

class Problem20
{
	public static void Main()
	{
		Stopwatch s = Stopwatch.StartNew();

		BigInteger result = BigInteger.One;
		for (int count = 2; count <= 100; count++)
			result = result * count;
		int sum = 0;
		while (result != BigInteger.Zero)
		{
			sum += (int) (result % 10);
			result /= 10;
		}
		Console.WriteLine(sum);

		s.Stop();
		Console.WriteLine("{0} ms", s.Elapsed);
	}

	static void Multiply(int num, int[] numArray)
	{
		for (int count = 0; count < numArray.Length; count++)
			numArray[count] *= num;

		for (int count = 0; count < numArray.Length; count++)
		{

			if (numArray[count] > 9)
			{
				numArray[count+1] += numArray[count] / 10;
				numArray[count] %= 10;
			}
		}
	}
}
