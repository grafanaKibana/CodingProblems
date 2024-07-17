namespace LeetCodeCs.ArraysAndHashing;

public static partial class Problem
{
    public static bool IsAnagram(string s, string t) => s.Length == t.Length && s.ToCharArray().Order().SequenceEqual(t.ToCharArray().Order());
}
