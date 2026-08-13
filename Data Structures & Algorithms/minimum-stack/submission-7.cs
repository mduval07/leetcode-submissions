public class MinStack {

    int index;
    int minValue;
    int[] stack;

    public MinStack() {
        index = 0;
        minValue = 0;
        stack = null;
    }
    
    public void Push(int val) {
        if (index == -1)
            minValue = val;

        else if (index == 0 && stack != null && val <= stack[0])
        {
            minValue = val;
        }
        else if (val < minValue)
        {
            minValue = val;
        }

        if (stack == null)
        {
            stack = new int[1];
            index = 0;
            stack[0] = val;
            minValue = val;
            return;
        }

        index++;
        

        // no room left in the array.  resize to * 2
        if (index == stack.Length)
        {
            Resize();
            stack[index] = val;
            return;
        }
        
        stack[index] = val;
    }
    
    public void Pop() {
        if (stack[index] == minValue)
        {
            int? newMin = null;
            // need to find the new min
            for (int i = 0; i < index; i++)
            {
                if (newMin == null || stack[i] < newMin)
                {
                    newMin = stack[i];
                }
            }

            if (newMin != null)
            {
                minValue = newMin.Value;
            }
            
        }

        index--;        
    }
    
    public int Top() {
        return stack[index];
    }
    
    public int GetMin() {
        return minValue;        
    }

    private void Resize()
    {
        var resized = new int[stack.Length * 2];
        for (int i = 0; i < stack.Length; i++)
        {
            resized[i] = stack[i];
        }

        stack = resized;
    }
}
