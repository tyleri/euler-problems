using System;
using System.Diagnostics;

class Problem15
{
	public static void Main(string[] args)
	{
		Stopwatch s = Stopwatch.StartNew();

		int size;
		try
		{
			size = Convert.ToInt32(args[0]);
		}
		catch (IndexOutOfRangeException e)
		{
			size = 10;
		}

		// Answer is 137,846,528,820
		Console.WriteLine(Rods(size, size));
		s.Stop();
		Console.WriteLine("Elapsed Time: {0} ms", s.ElapsedMilliseconds);	
	}

	static long Rods(int width, int height)
	{
		long sum = 0;
		
		/*
		if (width == 1)
			return height + 1;
		if (width == 2)
		{
			for (int count = 0; count <= height; count++)
				sum += count + 1;
		}
		*/
		if (width == 3)
		{
			for (int current = 1, times = height + 1; times >= 0; current++, times--)
				sum += current * times;
		}
		else
		{
			for (int i = 0; i <= height; i++)
				sum += Rods(width-1, i);
		}
		return sum;
	}

	// Old method, less efficient, unused now
	/*
	static long Lattice(int x, int y, int gridSize)
	{
		if (x == gridSize || y == gridSize)
			return 1;
		else
		{
			long result = 0;
			if (x < gridSize)
				result += Lattice(x+1, y, gridSize);
			if (y < gridSize)
				result += Lattice(x, y+1, gridSize);
			return result;
		}
	}
	*/

}
