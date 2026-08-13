public class Solution {
    public int[] GetConcatenation(int[] nums) {

        int[] ans = new int[2 * nums.Length];

        // [1,4,1,2]

        // [ 1, 4, 1,2,1 , , , ]

        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = nums[i];
            ans[i + nums.Length] = nums[i];
        }

        return ans;
        
    }
}