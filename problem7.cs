using System;

class Problem7
{
	public static void Main()
	{
		int count = 2, currentNum = 4;
		while (count < 10001)
		{
			currentNum++;
			for (int i = 2; i < currentNum; i++)
			{
				if (currentNum % i == 0)
					break;
				else if (i > currentNum / 2)
				{
					count++;
					break;
				}
			}
		}
		Console.WriteLine(currentNum);
	}
}
