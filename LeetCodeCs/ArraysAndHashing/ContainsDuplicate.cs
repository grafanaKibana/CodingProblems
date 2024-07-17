namespace LeetCodeCs.ArraysAndHashing;

public static partial class Problem
{
    public static bool ContainsDuplicate(int[] nums) => new HashSet<int>(nums).Count != nums.Length;
}
