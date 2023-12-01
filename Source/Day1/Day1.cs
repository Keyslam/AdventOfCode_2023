using System.Text.RegularExpressions;
using Source.Common;

namespace Source.Day1;

public class Day1(string[] input) : Day(input)
{
	public override string SolveFirstTask()
	{
		var result = Input
			.Select(line => FilterOutNonDigitChars(line))
			.Select(line =>
			{
				var first = line.First();
				var last = line.Last();
				var combinedNumber = first.ToString() + last.ToString();
				return Convert.ToInt32(combinedNumber);
			})
			.Sum();
		
		return result.ToString();
	}

	public override string SolveSecondTask()
	{
		var result = Input
			.Select(line => ReplaceTypedNumbers(line))
			.Select(line => FilterOutNonDigitChars(line))
			.Select(line =>
			{
				var first = line.First();
				var last = line.Last();
				var combinedNumber = first.ToString() + last.ToString();
				return Convert.ToInt32(combinedNumber);
			})
			.Sum();
		
		return result.ToString();
	}

	public static string ReplaceTypedNumbers(string str)
	{
		return str
			.Replace("one", "o1ne")
			.Replace("two", "t2wo")
			.Replace("three", "t3hree")
			.Replace("four", "f4our")
			.Replace("five", "f5ive")
			.Replace("six", "s6ix")
			.Replace("seven", "s7even")
			.Replace("eight", "s8eight")
			.Replace("nine", "s9nine");
	}
	
	public static string FilterOutNonDigitChars(string str)
	{
		var rx = new Regex(@"\D");
		return rx.Replace(str, "");
	}
}