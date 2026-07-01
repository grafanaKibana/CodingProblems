namespace LeetCodeCs.Greedy;

public static partial class Problem
{
    public static int MaxSubArray(int[] nums) {
        int current = nums[0];
        int best = nums[0];

        for(var i = 1; i < nums.Length; i++){
            if (nums[i] > current + nums[i]){
                current = nums[i];
            }
            else{
                current += nums[i];
            }

            if (current > best){
                best = current;
            }
        }

        return best;
    }
}