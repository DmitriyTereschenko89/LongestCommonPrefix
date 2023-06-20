namespace LongestCommonPrefix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CommonPrefixLongest commonPrefixLongest = new();
			Console.WriteLine(commonPrefixLongest.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
			Console.WriteLine(commonPrefixLongest.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
			Console.WriteLine(commonPrefixLongest.LongestCommonPrefix(new string[] { "" }));
			Console.WriteLine(commonPrefixLongest.LongestCommonPrefix(new string[] { "a" }));
			Console.WriteLine(commonPrefixLongest.LongestCommonPrefix(new string[] { "reflower", "flow", "flight" }));
        }
	}
}