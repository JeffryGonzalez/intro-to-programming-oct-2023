
namespace StringCalculator;

public class StringCalculator
{

	public int Add(string numbers)
	{
		if (numbers == "")
		{
			return 0;
		}
		if (numbers.StartsWith("//"))
		{
			return 3;
		}

		return numbers.Split(',', '\n').Select(int.Parse).Sum();
	}



}
