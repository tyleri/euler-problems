using System;

class Problem15
{
	public static void Main()
	{
		Console.WriteLine(Lattice(0, 0));
	}

	public static double Lattice(int x, int y)
	{
		double result = 0;

		if (x == 20 || y == 20)
			result++;
		else
		{
			if (x < 20)
				result += Lattice(x+1, y);
			if (y < 20)
				result += Lattice(x, y+1);
		}
		return result;
	}
}
