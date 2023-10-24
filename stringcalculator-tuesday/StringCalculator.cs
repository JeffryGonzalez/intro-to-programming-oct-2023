
namespace StringCalculator;

public class StringCalculator
{


	public int Add(string numbers)
	{
		var delimeters = new List<char> { ',', '\n' };
		if (numbers == "")
		{
			return 0;
		}
		if (numbers.StartsWith("//"))
		{
			delimeters.Add(numbers[2]);
			//numbers = numbers[4..];
			return parseNumbers(numbers[4..], delimeters);
		}

		int result = parseNumbers(numbers, delimeters);
		return result;
	}

	private int parseNumbers(string numbers, List<char> delimeters)
	{
		return numbers
					.Split(delimeters.ToArray())
					.Select(int.Parse)
					.Sum();
	}


}
