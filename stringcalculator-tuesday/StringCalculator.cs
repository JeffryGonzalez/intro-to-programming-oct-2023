
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
			var newDelimeter = numbers.Substring(2, 1);
			var realNumbers = numbers.Substring(4);
			return realNumbers.Split(newDelimeter).Select(int.Parse).Sum();
		}

		return numbers.Split(',', '\n').Select(int.Parse).Sum();
	}



}
