namespace LeetCodeCs.ArraysAndHashing;

public static partial class Problem
{
    public static int[] ProductExceptSelf(int[] nums)
    {
        #region Approach #1. Complexity: 0(n)
        var length = nums.Length;
        var result = new int[length];

        // Initialize the result array with 1's
        for (var i = 0; i < length; i++)
        {
            result[i] = 1;
        }

        var prefixProduct = 1;
        for (var i = 0; i < length; i++)
        {
            result[i] = prefixProduct;
            prefixProduct *= nums[i];
        }

        var suffixProduct = 1;
        for (var i = length - 1; i >= 0; i--)
        {
            result[i] *= suffixProduct;
            suffixProduct *= nums[i];
        }

        return result;
        #endregion

        #region Approach #2. Complexity: 0(n^2)
        /*
        var result = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            var temp = 1;
            for (var j = 0; j < nums.Length; j++)
            {
                if (i == j)
                {
                    continue;
                }

                temp *= nums[j];
            }

            result[i] = temp;
        }

        return result;
        */
        #endregion

        #region Approach #3. Complexity: 0(n^3)
        /*
        return nums.Select((_, i) => nums.Where((_, j) => i != j).Aggregate(1, (a, b) => a * b)).ToArray();
        */
        #endregion
    }
}
