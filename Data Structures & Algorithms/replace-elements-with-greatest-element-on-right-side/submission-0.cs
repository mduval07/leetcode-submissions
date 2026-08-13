public class Solution {
    public int[] ReplaceElements(int[] arr) {

        int max = 0;
        // [2,4,5,3,1,2]

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            var thisVal = arr[i];
            
            if (i == arr.Length - 1)
            {
                max = thisVal; 
                arr[i] = -1;
                continue;
            }

            arr[i] = max;    
            max = Math.Max(thisVal, max);
        }    

        return arr;    
    }
}