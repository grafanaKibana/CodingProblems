namespace LeetCodeCs.TwoPointers;

public static partial class Problem
{
    public static List<List<int>> ThreeSum(int[] nums)
    {
        var sortedNums = new List<int>(nums.Order());

        var triplets = new List<List<int>>();

        if (sortedNums[0] > 0 || sortedNums.Count < 3)
        {
            return triplets;
        }

        for (var i = 0; i < sortedNums.Count; i++)
        {
            if (sortedNums[i] > 0)
            {
                break;
            }

            if (i > 0 && sortedNums[i] == sortedNums[i - 1])
            {
                continue;
            }

            var firstIdx = i + 1;
            var lastIdx = sortedNums.Count - 1;

            while (firstIdx < lastIdx)
            {
                var sum = sortedNums[i] + sortedNums[firstIdx] + sortedNums[lastIdx];
                switch (sum)
                {
                    case 0:
                    {
                        triplets.Add([sortedNums[i], sortedNums[firstIdx], sortedNums[lastIdx]]);

                        while (firstIdx < lastIdx && sortedNums[firstIdx] == sortedNums[firstIdx + 1])
                        {
                            firstIdx++;
                        }

                        while (firstIdx < lastIdx && sortedNums[lastIdx] == sortedNums[lastIdx - 1])
                        {
                            lastIdx--;
                        }

                        firstIdx++;
                        lastIdx--;
                        break;
                    }
                    case < 0:
                    {
                        firstIdx++;
                        break;
                    }
                    case > 0:
                    {
                        lastIdx--;
                        break;
                    }
                }
            }
        }

        return triplets;
    }
}
