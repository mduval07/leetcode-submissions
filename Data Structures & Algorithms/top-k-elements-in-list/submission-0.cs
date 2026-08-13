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

        // 1. Initialize a Min-Heap Priority Queue (Default)
        PriorityQueue<int, int> queue = new();

        foreach (var (key, value) in dict) {
            queue.Enqueue(key, value);
        }

        // 3. Process elements
        while (queue.Count > k) {
            // Dequeues the lowest intger priority first (1, then 2, then 3)
            queue.Dequeue();
        }

        var returnVal = new int[k];

        int index = 0;
        while (queue.Count > 0)
        {
            returnVal[index] = queue.Dequeue();
            index++;
        }

        return returnVal;
    }
}