using LeetCode.Easy._0001_TwoSum;

class Program
{
    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        var s = new Solution();
        var res = s.TwoSum(nums, target);

        Console.WriteLine(string.Join(", ", res));
    }
}