namespace LeetCodeCs.TwoPointers;

public static partial class Problem
{
    #region Recursive Approach #1 (Uses a lot of memory because of substring)
    public static bool IsPalindrome(string s) {
        s = string.Concat(Array.FindAll(s.ToCharArray(), char.IsLetterOrDigit)).ToLowerInvariant();

        return s.Length switch
        {
            <= 1 => true,
            <= 2 => s[0] == s[1],
            _ => s[0] == s[^1] && IsPalindrome(s.Substring(1, s.Length - 2))
        };
    }
    #endregion#

    /*#region Recursive Approach #2
    public static bool IsPalindrome(string s)
    {
        s = string.Concat(Array.FindAll(s.ToCharArray(), char.IsLetterOrDigit)).ToLowerInvariant();

        return IsPalindromeRecursive(s, 0, s.Length - 1);
    }

    private static bool IsPalindromeRecursive(string s, int left, int right)
    {
        return left >= right || s[left] == s[right] && IsPalindromeRecursive(s, left + 1, right - 1);
    }
    #endregion#*/

    /*#region Iterative Approach
    public static bool IsPalindrome(string s)
    {
        s = string.Concat(Array.FindAll(s.ToCharArray(), char.IsLetterOrDigit)).ToLowerInvariant();

        while (true)
        {
            switch (s.Length)
            {
                case <= 1:
                {
                    return true;
                }
                case <= 2:
                {
                    return s[0] == s[1];
                }
                default:
                {
                    if (s[0] != s[^1])
                    {
                        return false;
                    }

                    s = s.Substring(1, s.Length - 2);
                    break;
                }
            }
        }
    }
    #endregion#*/
}
