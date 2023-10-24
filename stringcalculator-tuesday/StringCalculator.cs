
namespace StringCalculator;

public class StringCalculator
{

	public int Add(string numbers)
	{
		if (numbers == "")
		{
			return 0;
		}

		var individualNumbers = numbers.Split(',');
		var total = 0;
		foreach (var num in individualNumbers)
		{
			total += int.Parse(num);
		}
		return total;
	}



}
