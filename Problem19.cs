using System;

class Problem19
{
	public static void Main()
	{
		DateTime d1 = new DateTime(1901, 1, 1);
		DateTime d2 = new DateTime(2000, 12, 31);
		Console.WriteLine("{0} was a {1}", d1.Date, d1.DayOfWeek);
		Console.WriteLine("{0} was a {1}", d2.Date, d2.DayOfWeek);
		int sumSundays = 0;
		while (d1 < d2)
		{
			if (d1.DayOfWeek == DayOfWeek.Sunday)
				sumSundays++;
			d1 = d1.AddMonths(1);
		}
		Console.WriteLine("There were {0} Sundays that fell on the first of the month", sumSundays);
	}
}
