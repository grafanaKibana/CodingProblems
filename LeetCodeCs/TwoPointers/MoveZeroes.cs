namespace LeetCodeCs.TwoPointers;

public static partial class Problem
{
    public static void MoveZeroes(int[] nums) {
        if(nums.Length <= 1){
            return;
        }

        int firstZeroIndex = -1;
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] == 0){
                if (firstZeroIndex == -1) {
                    firstZeroIndex = i;
                }
            }
            else{
                if (firstZeroIndex != -1) {
                    var temp = nums[i];
                    nums[i] = nums[firstZeroIndex];
                    nums[firstZeroIndex] = temp;
                    firstZeroIndex++;
                }
            }
        }
    }
}
