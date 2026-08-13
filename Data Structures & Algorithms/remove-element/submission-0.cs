public class Solution {
    public int RemoveElement(int[] nums, int val) {
        //[3,2,2,3], val = 3
        int numCount = 0;
        int k = 0;  // k is numbers in the array not equal to the given val
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == val) {
                numCount++;
                continue;
            }

            nums[i - numCount] = nums[i];
            k++;
        }

        return k;
    }
}