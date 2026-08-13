public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        var dict = new Dictionary<int,int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var targetInMap = target - nums[i];
            if (dict.TryGetValue(targetInMap, out var targetIndex))
            {
                if (i < targetIndex)
                    return [i,targetIndex];
                return [targetIndex, i];
            }

            dict[nums[i]] = i;
        }

        return [];

    }
}
