public class Solution {
    public bool IsValid(string s) {

        if (s.Length <= 1)
        {
            return false;
        }

        var st = new Stack<char>();
        var dict = new Dictionary<char,char>
        {
            {']', '['},
            {')', '('},
            {'}', '{'}
        };

        foreach (var c in s)
        {
            if (c == '[' || c == '{' || c == '(')
            {
                st.Push(c);
                continue;
            }

            if (c == ']' || c == '}' || c == ')')
            {
                if (dict.TryGetValue(c, out var charToFind))
                {
                    if (!st.TryPop(out var popped) || popped != charToFind)
                        return false;
                }
            }
        }

        if (st.Count > 0)
            return false;

        return true;
    }
}
