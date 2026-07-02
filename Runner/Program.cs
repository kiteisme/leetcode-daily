using LeetCode.Easy._0004_longestCommonprefix;

Solution solution = new Solution();

string[][] testCases =
{
    new string[] { "flower", "flow", "flight" },
    new string[] { "dog", "racecar", "car" },
    new string[] { "interspecies", "interstellar", "interstate" },
    new string[] { "apple", "app", "application" },
    new string[] { "a" },
    new string[] { "", "" }
};

foreach (string[] strs in testCases)
{
    Console.WriteLine($"Input: [{string.Join(", ", strs)}]");
    Console.WriteLine($"Output: \"{solution.LongestCommonPrefix(strs)}\"");
    Console.WriteLine(new string('-', 40));
}