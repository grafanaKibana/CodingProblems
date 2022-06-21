namespace CodeWarsCs.Kyu5;

public static partial class Kata
{
    public static string FirstNonRepeatingLetter(string s) =>
        s.Count(x =>
            string.Equals(x.ToString(), s.First().ToString(), StringComparison.OrdinalIgnoreCase)) > 1
            ? FirstNonRepeatingLetter(s.Replace(s.First().ToString(), ""))
            : s.Length < 1 ? "" : s.First().ToString();
}