public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        var dict = new HashSet<int>();

        foreach (var num in nums)
        {
            if (dict.Contains(num))
                return true;
            
            dict.Add(num);
        }

        return false;
        
    }
}