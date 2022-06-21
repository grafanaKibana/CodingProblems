namespace CodeWarsCs.Kyu7;

public static partial class Kata
{
    public static int GetMissingElement(int[] superImportantArray)
    {
        for (var i = 0; i <= superImportantArray.Length; i++)
        {
            if (!superImportantArray.Contains(i))
            {
                return i;
            }
        }

        return 0;
    }
}