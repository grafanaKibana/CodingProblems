namespace LeetCodeCs.Backtracking;

public static partial class Problem
{
    public static IList<IList<int>> Subsets(int[] nums) {
        var subsets = new List<IList<int>>();
        var currentSet = new Stack<int>();

        Deside(0, nums, currentSet, subsets);

        return subsets;


    }

    private static void Deside(int i, int[] nums, Stack<int> currentSet, List<IList<int>> subsets){
        if(i >= nums.Length){
            subsets.Add(new List<int>(currentSet));
            return;
        }

        Deside(i + 1, nums, currentSet, subsets);

        currentSet.Push(nums[i]);
        Deside(i + 1, nums, currentSet, subsets);
        currentSet.Pop();
    }
}