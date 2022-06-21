namespace CodeWarsCs.Kyu7;

public static partial class Kata
{
    public static int SumTwoSmallestNumbers(IEnumerable<int> numbers) => numbers.ToList().OrderBy(x => x).Take(2).Sum();
}