namespace LeetCodeCs.Stack;

public static partial class Problem
{
    public static bool IsValid(string s) {
        var dict = new Dictionary<char, char>{
            { ')', '(' },
            { '}', '{' },
            { ']', '['},
        };

        if (s.Length % 2 == 1 || dict.ContainsKey(s[0]) || dict.ContainsValue(s[^1])) return false;


        var stack = new Stack<char>();

        for (var i = 0; i < s.Length; i++){
            if (dict.ContainsKey(s[i])){
                if(stack.Count > 0 && stack.Peek() == dict[s[i]]){
                    stack.Pop();
                }
                else {
                    return false;
                }

            }
            else {
                stack.Push(s[i]);
            }
        }

        return stack.Count == 0;
    }
}