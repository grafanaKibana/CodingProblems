namespace CodeWarsCs.Kyu6;

public static partial class Kata
{
    public static string SpinWords(string sentence) => 
        string.Join(" ", sentence.Split(" ").Select(x => x.Length >=5 ? new string(x.Reverse().ToArray()) : x).ToList());
}