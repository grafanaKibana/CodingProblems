namespace LeetCodeCs.TwoPointers;

public static partial class Problem
{
    #region Single Loop + 2 Pointers = Fast
    public static int[] TwoSum(int[] numbers, int target)
    {
        var firstIdx = 0;
        var lastIdx = numbers.Length - 1;

        while (true)
        {
            switch (numbers[firstIdx] + numbers[lastIdx] - target)
            {
                case 0:
                    return [firstIdx + 1, lastIdx + 1];
                case > 0:
                    lastIdx--;
                    continue;
                case < 0:
                    firstIdx++;
                    continue;
            }
        }
    }
    #endregion


    /*#region Recursion Approach But OutOfMemory <3
    public static int[] TwoSum(int[] numbers, int target)
    {
        return Recursion(numbers);

        int[] Recursion(int[] nums)
        {
            return (nums[0] + nums[^1] - target) switch
            {
                0 => [Array.IndexOf(numbers, nums[0]) + 1, Array.LastIndexOf(numbers, nums[^1]) + 1],
                > 0 => Recursion(new List<int>(nums).GetRange(0, nums.Length - 1).ToArray()),
                < 0 => Recursion(new List<int>(nums).GetRange(1, nums.Length - 1).ToArray()),
            };
        }
    }
    #endregion*/

    /*#region Single Loop But Still Slow
    public static int[] TwoSum(int[] numbers, int target)
    {
        if (numbers.Length <= 2)
        {
            return [1, 2];
        }

        for (var first = 0; first < numbers.Length; first++)
        {
            var second = Array.LastIndexOf(numbers, target - numbers[first]);
            if (second == -1)
            {
                continue;
            }

            if (target - numbers[first] == numbers[second])
            {
                return [first + 1, second + 1];
            }
        }

        return [0, 0];
    }
    #endregion*/

    /*
    #region Straight Forward Approach With Two Loops
    public static int[] TwoSum(int[] numbers, int target)
    {
        if (numbers.Length <= 2)
        {
            return [1, 2];
        }

        for (var i = 0; i < numbers.Length; i++)
        {
            for (var j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return [i + 1, j + 1];
                }
            }
        }

        return [0, 0];
    }
    #endregion
    */
}
