using Tests.Common;
using Xunit.Abstractions;

namespace Tests.Day1;

public class Tests(ITestOutputHelper output)
{
	[Theory]
	[JsonFileData("Day1/input.txt")]
	public void SolveFirst(string[] data)
	{
		var day = new Source.Day1.Day1(data);
		var result = day.SolveFirstTask();
		
		Assert.Equal("53651", result);
	}
	
	[Theory]
	[JsonFileData("Day1/input.txt")]
	public void SolveSecond(string[] data)
	{
		var day = new Source.Day1.Day1(data);
		var result = day.SolveSecondTask();
		
		Assert.Equal("53894", result);
	}
	
	[Theory]
	[JsonFileData("Day1/Sample_1.txt")]
	public void SolveSample1(string[] data)
	{
		var day = new Source.Day1.Day1(data);
		var result = day.SolveFirstTask();
		
		Assert.Equal("142", result);
	}
	
	[Theory]
	[JsonFileData("Day1/Sample_2.txt")]
	public void SolveSample2(string[] data)
	{
		var day = new Source.Day1.Day1(data);
		var result = day.SolveSecondTask();
		
		Assert.Equal("281", result);
	}

	[Theory]
	[InlineData("abc", "")]
	[InlineData("abc123def", "123")]
	[InlineData("123", "123")]
	[InlineData("a12b34cd56", "123456")]
	public void FilterNonDigitStrings(string input, string expected)
	{
		var result = Source.Day1.Day1.FilterOutNonDigitChars(input);
		Assert.Equal(expected, result);
	}
}