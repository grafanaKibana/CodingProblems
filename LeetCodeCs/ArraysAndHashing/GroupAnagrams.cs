namespace LeetCodeCs.ArraysAndHashing;

public static partial class Problem
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var res = strs
            .GroupBy(str => new string(str.OrderBy(x => x).ToArray()))
            .Select(group => group.ToList())
            .ToList();

        return new List<IList<string>>(res);
    }
}
