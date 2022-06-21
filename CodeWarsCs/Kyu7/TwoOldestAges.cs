namespace CodeWarsCs.Kyu7;

public static partial class Kata
{
    public static int[] TwoOldestAges(int[] ages) => ages.OrderBy(x => x).Reverse().Take(2).Reverse().ToArray();
}