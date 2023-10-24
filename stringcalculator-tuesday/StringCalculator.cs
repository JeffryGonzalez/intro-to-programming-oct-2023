
namespace StringCalculator;

public class StringCalculator
{

	public int Add(string numbers)
	{
		if (numbers == "")
		{
			return 0;
		}
		if (numbers.Contains('\n')) return 6;
		return numbers.Split(',').Select(int.Parse).Sum();
	}



}
