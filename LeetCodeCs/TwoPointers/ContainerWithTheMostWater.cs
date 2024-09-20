namespace LeetCodeCs.TwoPointers;

public static partial class Problem
{
    #region Solution1
    public static int MaxArea(int[] height)
    {
        var maxArea = 0;

        for (int i = 0, j = height.Length - 1; i < j;)
        {
            var area = Math.Min(height[i], height[j]) * (j - i);

            if (area > maxArea)
            {
                maxArea = area;
            }

            if (height[i] <= height[j])
            {
                i++;
            }
            else
            {
                j--;
            }
        }

        return maxArea;
    }
    #endregion
}
