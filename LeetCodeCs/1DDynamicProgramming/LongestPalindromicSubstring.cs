namespace LeetCodeCs._1DDynamicProgramming;

public static partial class Problem
{
    public static string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return "";
        int bestStart = 0, bestEnd = 0;

        for(var i = 0; i < s.Length; i++){
            // Odd
            int left = i, right = i;

            while(left >= 0 && right < s.Length && s[left] == s[right]){
                if((right - left + 1) > (bestEnd - bestStart)){
                    bestStart = left;
                    bestEnd = right + 1;
                }

                left--;
                right++;
            }

            // Even
            left = i;
            right = i + 1;

            while(left >= 0 && right < s.Length && s[left] == s[right]){
                if((right - left + 1) > (bestEnd - bestStart)){
                    bestStart = left;
                    bestEnd = right + 1;
                }

                left--;
                right++;
            }
        }

        return s[bestStart..bestEnd];
    }
}