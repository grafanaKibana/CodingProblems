namespace CodeWarsCs.Kyu7;

public static partial class Kata
{
    public static IEnumerable<string> FriendOrFoe (string[] names) => names.Where(n => n.Length == 4);
}