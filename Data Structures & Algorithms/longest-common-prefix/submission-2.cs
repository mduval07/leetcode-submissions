public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length;j++)
            {
                char c = strs[0][i];

                if (i >= strs[j].Length || c != strs[j][i])
                {
                    return strs[0].Substring(0,i);
                }
            }
        }

        return strs[0];
        
    }
}