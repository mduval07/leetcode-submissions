public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        

        //the way I'd do this is find the total value of the ascii chars
        // then use a dictonary to store the int/List<string> combinations.

        // then for each entry in the dictionary, i'd just add them to a new list
        // and return;

        var map = new Dictionary<string,List<string>>();

        foreach (var candidate in strs)
        {
            var cArray = candidate.ToCharArray();
            Array.Sort(cArray);
            var sorted = new string(cArray);
            if (map.TryGetValue(sorted, out var anagrams))
            {
                anagrams.Add(candidate);
                continue;
            }

            map.Add(sorted, new List<string>{candidate});
        }

        var returnValue = new List<List<string>>();
        foreach (var val in map.Values)
        {
            returnValue.Add(val);
        }

        return returnValue;
    }
}
