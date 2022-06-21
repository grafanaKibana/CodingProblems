namespace CodeWarsCs.Kyu5;

public static partial class Kata
{
    public static string Rgb(int r, int g, int b) 
    {
        var rhex = Math.Max(Math.Min(255, r), 0);
        var ghex = Math.Max(Math.Min(255, g), 0);
        var bhex = Math.Max(Math.Min(255, b), 0);
        return $"{rhex:X2}{ghex:X2}{bhex:X2}";
    }
}