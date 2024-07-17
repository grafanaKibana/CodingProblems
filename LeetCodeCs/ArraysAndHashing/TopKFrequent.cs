namespace LeetCodeCs.ArraysAndHashing;

public static partial class Problem
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        return nums.GroupBy(x => x)
            .Select(x => new
            {
                Number = x.Key,
                Count = x.Count(),
            })
            .OrderByDescending(x => x.Count)
            .Take(k)
            .Select(x => x.Number)
            .ToArray();
    }
}
