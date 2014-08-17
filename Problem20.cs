using System;
using System.Diagnostics;
using System.Linq;

class Problem20
{
	public static void Main()
	{
		Stopwatch s = Stopwatch.StartNew();
		int[] result = new int[200];
		result[0] = 1;

		for (int count = 2; count <= 100; count++)
			Multiply(count, result);

		Console.WriteLine(result.Sum());
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
