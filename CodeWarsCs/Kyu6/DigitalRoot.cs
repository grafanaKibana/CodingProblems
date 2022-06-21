namespace CodeWarsCs.Kyu6;

public static partial class Kata
{
    public static int DigitalRoot(long n) => n.ToString().Length == 1 ? (int)n : DigitalRoot((long)n.ToString().ToCharArray().Sum(char.GetNumericValue));
}