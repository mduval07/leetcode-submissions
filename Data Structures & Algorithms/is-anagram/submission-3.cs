public class Solution {
    public bool IsAnagram(string s, string t) {

        if (t.Length != s.Length)
            return false;

        var dictS = new Dictionary<char,int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (dictS.ContainsKey(s[i]))
            {
                dictS[s[i]]++;
                continue;
            }

            dictS.Add(s[i], 1);
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (dictS.TryGetValue(t[i], out var count) && count > 0)
            {
                dictS[t[i]]--;
                continue;
            }
            
            return false;
        }

        return true;

    }
}
