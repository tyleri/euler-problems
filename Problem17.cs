using System;

class Problem17
{
	public static void Main()
	{
		string fullString = "";
		for (int count = 1; count <= 1000; count++)
		{
			fullString += ToWords(count);
		}
		Console.WriteLine(fullString);
		
		fullString = fullString.Replace(" ", null);
		Console.WriteLine(fullString.Length);
	}

	static string ToWords(int num)
	{
		int[] numArray = SplitNumber(num);
		string numString = "";
		int placeValue = numArray.Length - 1;
		for (int count = 0; count < numArray.Length; count++, placeValue--)
		{
			if (placeValue == 1)
			{
				if ((numArray[count] != 0 || numArray[count+1] != 0) && numArray.Length > 2)
					numString += "and ";
				if (numArray[count] == 1)
					numString += ToWord(10 + numArray[++count]);
				else
					numString += ToWord(10 * numArray[count]);
			}
			else if (numArray[count] == 0)
				continue;
			else
			{
				numString += ToWord(numArray[count]);
				if (placeValue != 0)
				{
					numString += " ";
					numString += ToWord((int) Math.Pow(10, placeValue));
				}
			}
			numString += " ";
		}
		return numString;
	}

	static string ToWord(int number)
	{
		switch (number)
		{
			case 1:
				return "one";
			case 2:
				return "two";
			case 3:
				return "three";
			case 4:
				return "four";
			case 5:
				return "five";
			case 6:
				return "six";
			case 7:
				return "seven";
			case 8:
				return "eight";
			case 9:
				return "nine";
			case 10:
				return "ten";
			case 11:
				return "eleven";
			case 12:
				return "twelve";
			case 13:
				return "thirteen";
			case 14:
				return "fourteen";
			case 15:
				return "fifteen";
			case 16:
				return "sixteen";
			case 17:
				return "seventeen";
			case 18:
				return "eighteen";
			case 19:
				return "nineteen";
			case 20:
				return "twenty";
			case 30:
				return "thirty";
			case 40:
				return "forty";
			case 50:
				return "fifty";
			case 60:
				return "sixty";
			case 70:
				return "seventy";
			case 80:
				return "eighty";
			case 90:
				return "ninety";
			case 100:
				return "hundred";
			case 1000:
				return "thousand";
			default:
				return "";
		}
	}

	static int[] SplitNumber(int number)
	{
		int[] numArray = new int[number.ToString().Length];
		for (int count = 0; count < numArray.Length; count++)
		{
			numArray[count] = number % 10;
			number /= 10;
		}
		Array.Reverse(numArray);
		return numArray;
	}
}
