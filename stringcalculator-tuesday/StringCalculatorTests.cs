
namespace StringCalculator;

public class StringCalculatorTests
{
	[Fact]
	public void EmptyStringReturnsZero()
	{
		var calculator = new StringCalculator();

		var result = calculator.Add("");

		Assert.Equal(0, result);
	}

	[Theory]
	[InlineData("1", 1)]
	[InlineData("2", 2)]
	[InlineData("118", 118)]
	public void SingleDigit(string input, int expected)
	{
		var calculator = new StringCalculator();
		var result = calculator.Add(input);
		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("1,1", 2)]
	[InlineData("10,2", 12)]
	public void TwoDigits(string input, int expected)
	{
		var calculator = new StringCalculator();
		var result = calculator.Add(input);
		Assert.Equal(expected, result);
	}
}
