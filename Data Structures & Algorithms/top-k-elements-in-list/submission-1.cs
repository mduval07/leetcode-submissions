public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey(nums[i])) {
                dict[nums[i]]++;
            } else {
                dict[nums[i]] = 1;
            }
        }

        PriorityQueue<int, int> queue = new();

        foreach (var (key, value) in dict) {
            queue.Enqueue(key, value);
            if (queue.Count > k)
                queue.Dequeue();
        }

        var returnVal = new int[k];

        int index = 0;
        while (queue.Count > 0) {
            returnVal[index] = queue.Dequeue();
            index++;
        }

        return returnVal;
    }
}