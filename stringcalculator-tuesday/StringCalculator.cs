
namespace StringCalculator;

public class StringCalculator
{

	public int Add(string numbers)
	{
		if (numbers.Contains(','))
		{
			var lhs = numbers.Substring(0, numbers.IndexOf(','));
			var rhs = numbers.Substring(numbers.IndexOf(",") + 1);

			return int.Parse(lhs) + int.Parse(rhs);
		}
		if (numbers == "")
		{
			return 0;
		}
		else
		{
			return int.Parse(numbers);
		}
	}
}
