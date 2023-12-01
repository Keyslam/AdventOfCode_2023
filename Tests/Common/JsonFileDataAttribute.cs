using System.Reflection;
using Xunit.Sdk;

namespace Tests.Common;

public class JsonFileDataAttribute(string filePath) : DataAttribute
{
	private static readonly string[] NewLineCharacters = new string[] { "\r\n", "\r", "\n" };
	
	public override IEnumerable<object[]> GetData(MethodInfo testMethod)
	{
		ArgumentNullException.ThrowIfNull(testMethod);

		var path = Path.IsPathRooted(filePath)
			? filePath
			: Path.GetRelativePath(Directory.GetCurrentDirectory(), filePath);

		if (!File.Exists(path))
		{
			throw new ArgumentException($"Could not find file at path: {path}");
		}

		var fileData = File.ReadAllText(filePath);
		var lines = fileData.Split(
			NewLineCharacters,
			StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries
		);

		return new List<object[]>() { new object[] { lines } };
	}
}