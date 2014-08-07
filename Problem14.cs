using System;

class Problem14
{
	public static void Main()
	{
		int longest = 0;
		int start = 0;
		
		for (int i = 1; i < 1000000; i++)
			if (Collatz(i) > longest)
			{
				longest = Collatz(i);
				start = i;
			}
		
		Console.WriteLine(start + " " + longest);
	}

	public static int Collatz(int start)
	{
		long begin = start;
		int numTerms = 1;

		while (begin > 1)
		{
			if (begin % 2 == 0)
				begin /= 2;
			else
				begin = begin * 3 + 1;
			numTerms++;
		}
		
		return numTerms;
	}
}
