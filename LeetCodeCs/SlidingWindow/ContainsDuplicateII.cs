namespace LeetCodeCs.SlidingWindow;

public static partial class Problem
{
    public static bool ContainsNearbyDuplicate(int[] nums, int k) {
        var window = new HashSet<int>();

        for(int left = 0, right = 0; right < nums.Length; right++){
            if(right - left > k){
                window.Remove(nums[left]);
                left++;
            }

            if(window.Contains(nums[right])){
                return true;
            }

            window.Add(nums[right]);
        }

        return false;
    }
}