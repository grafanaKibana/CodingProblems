namespace LeetCodeCs.ArraysAndHashing;

public static partial class Problem
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var indices = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (indices.TryGetValue(diff, out var index)) {
                return [index, i];
            }

            indices[nums[i]] = i;
        }
        return null!;
    }
}
