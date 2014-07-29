using System;

class problem3
{
	public static void Main()
	{
		long currentNum = 600851475143L, result = currentNum;
		for (int i = 1; i < currentNum; i++) {
			while (result != currentNum)
			{
				currentNum = result;
				result = simp(currentNum, i);
			}
		}
		Console.WriteLine(currentNum);

	}

	public static long simp(long num, int dividend)
	{
		if (num % dividend == 0)
			return num / dividend;
		else
			return num;
	}
}
