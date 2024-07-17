namespace CodeWarsCs.Kyu5;

public static partial class Kata
{
    public static string Rgb(int r, int g, int b) 
    {
        var redHex = Math.Max(Math.Min(255, r), 0);
        var greenHex = Math.Max(Math.Min(255, g), 0);
        var blueHex = Math.Max(Math.Min(255, b), 0);
        return $"{redHex:X2}{greenHex:X2}{blueHex:X2}";
    }
}
