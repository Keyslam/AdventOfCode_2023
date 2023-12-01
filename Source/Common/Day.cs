namespace Source.Common;

public abstract class Day(string[] input)
{
	protected string[] Input { get; } = input;

	public abstract string SolveFirstTask();
	public abstract string SolveSecondTask();
}