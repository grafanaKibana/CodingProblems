namespace CodeWarsCs.Kyu7;

public static partial class Kata
{
    public static bool IsSquare(int n)
    {
        var squareNums = new List<int>();
        for (var i = 0; i < 50; i++)
        {
            squareNums.Add(i*i);
        }

        return squareNums.Any(elem => elem == n);
    }
}