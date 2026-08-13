public class Solution {
    public int MajorityElement(int[] nums) {

        if (nums.Length == 1)
            return nums[0];

        var dict = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.TryGetValue(nums[i], out var count))
            {
                count++;
                if (count > nums.Length / 2)
                {
                    return nums[i];
                }
                dict[nums[i]]++;
            }
            else {
                dict.Add(nums[i],1);
            }
        }

        return 0;
        
    }
}