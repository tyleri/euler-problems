using System;
using System.Diagnostics;

class Problem7
{
	public static void Main()
	{
		Stopwatch s = Stopwatch.StartNew();
		int count = 2, currentNum = 4;
		while (count < 10001)
		{
			currentNum++;
			for (int i = 2; currentNum % i != 0; i++)
				if (i > Math.Sqrt(currentNum))
				{
					count++;
					break;
				}
		}
		Console.WriteLine(currentNum);
		s.Stop();
		Console.WriteLine("Time Elapsed: {0}", s.Elapsed);
	}
}
