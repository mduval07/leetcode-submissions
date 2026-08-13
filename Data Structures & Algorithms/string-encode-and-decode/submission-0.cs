public class Solution {
    public string Encode(IList<string> strs) {
        if (strs.Count == 0) {
            return "";
        }

        var sb = new StringBuilder();
        foreach (var str in strs) {
            sb.Append($"{str.Length}#{str}");
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        if (string.IsNullOrEmpty(s))
            return new List<string>();

        var returnList = new List<string>();
        int i = 0;
        while (i < s.Length) {
            int sharpIndex = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, sharpIndex - i));

            i = sharpIndex + 1;
            string word = s.Substring(i, length);

            i += length;
            returnList.Add(word);
        }
        return returnList;
    }
}