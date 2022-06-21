using System.Text;

namespace CodeWarsCs.Kyu6;

public static partial class Kata
{
    public static string CleanString(string s)
    {
        var result = new StringBuilder();
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if (c is '#')
            {
                if (stack.Count <= 0) continue;
                stack.Pop();
                result.Remove(result.Length - 1, 1);
            }
            else
            {
                stack.Push(c);
                result.Append(c);
            }
        }
        return result.ToString();
    }
}