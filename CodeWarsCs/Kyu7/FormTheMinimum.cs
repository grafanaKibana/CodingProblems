using System.Text;

namespace CodeWarsCs.Kyu7;

public static partial class Kata
{
    public static long MinValue(int[] a)
    {
        var result = new StringBuilder();
        a.ToList().Distinct().OrderBy(x => x).ToList().ForEach(x => result.Append(x));
        return Convert.ToInt64(result.ToString());
    }
}