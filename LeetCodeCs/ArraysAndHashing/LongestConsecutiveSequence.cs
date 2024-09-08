namespace LeetCodeCs.ArraysAndHashing;

public static partial class Problem
{
    #region FORIF Approach
    public static int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var count = 1;
        var longest = 1;

        var orderedNums = nums.Order().ToList();

        for (var index = 0; index < nums.Length - 1; index++)
        {
            if (orderedNums[index] + 1 == orderedNums[index + 1])
            {
                count++;

                if (count > longest)
                {
                    longest = count;
                }
            }
            else
            {
                if (orderedNums[index] == orderedNums[index + 1])
                {
                    continue;
                }

                count = 1;
            }
        }

        return longest;
    }
    #endregion

    /*#region HashSetApproach
    public static int LongestConsecutive(int[] nums)
    {
        var hashSet = new HashSet<int>(nums);
        var result = 0;

        foreach (var num in nums)
        {
            if (hashSet.Contains(num - 1))
            {
                continue;
            }

            var length = 0;
            while (hashSet.Contains(num + length))
            {
                length++;
            }
            result = Math.Max(result, length);
        }
        return result;
    }
    #endregion*/

}
