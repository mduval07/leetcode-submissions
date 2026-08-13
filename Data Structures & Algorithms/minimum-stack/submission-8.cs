public class MinStack {

    private Stack<int> valStack;
    private Stack<int> minStack;

    public MinStack() {
        valStack = new Stack<int>();
        minStack = new Stack<int>();        
    }
    
    public void Push(int val) {
        valStack.Push(val);

        if (minStack.TryPeek(out var last))   
        {
            if (val < last)
                minStack.Push(val);
            else
                minStack.Push(last);
            return;
        }

        minStack.Push(val);
    }
    
    public void Pop() {
        valStack.Pop();
        minStack.Pop();        
    }
    
    public int Top() {
        return valStack.Peek();
    }
    
    public int GetMin() {
        return minStack.Peek();     
    }
}
