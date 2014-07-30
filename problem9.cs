using System;

class problem9
{
	public static void Main()
	{
		double a, b, c;

		for (a = 2; a < 1000 ; a++)
		{
			for (b = 2; b < 1000 ; b++)
			{
				c = Math.Sqrt(a*a+b*b);
				if (a + b + c == 1000)
				{
					Console.WriteLine(a * b * c);
					return;
				}
			}
		}
	}
}
