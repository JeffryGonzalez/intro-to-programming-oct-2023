﻿
namespace StringCalculator;

public class StringCalculator
{

	public int Add(string numbers)
	{
		if (numbers == "")
		{
			return 0;
		}

		// select - map
		return numbers.Split(',', '\n') // => ["1", "2", "3"...]
			.Select(int.Parse) // => [1,2,3,4,6]
			.Sum(); // Language Integrated Query

	}
}
