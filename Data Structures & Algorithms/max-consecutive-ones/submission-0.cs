public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {

        int maxOnes = 0;

        int currentOnes = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                currentOnes++;
                continue;
            }
            
            maxOnes = Math.Max(currentOnes, maxOnes);
            currentOnes = 0;
        }

        return Math.Max(currentOnes, maxOnes);        
    }
}