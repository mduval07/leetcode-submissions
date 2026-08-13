public class DynamicArray {
    
    private int capacity;
    private int size;
    private int[] myArray;

    public DynamicArray(int capacity) {
        this.capacity = capacity;
        myArray = new int[capacity];
        size = 0;
    }

    public int Get(int i) {
        return myArray[i];        
    }

    public void Set(int i, int n) {
        myArray[i] = n;
    }

    public void PushBack(int n) 
    {        
        if (size == myArray.Length) 
            Resize();
        myArray[size] = n;
        size++;
    }

    public int PopBack() {
        var returnValue = myArray[size - 1];
        size--;
        return returnValue;
    }

    private void Resize() {
         var newArray = new int[capacity * 2];     
        for (int i = 0; i < myArray.Length; i++)
        {
            newArray[i] = myArray[i];
        }        
        capacity *= 2;
        myArray = newArray;    
    }

    public int GetSize() {
         return size;
    }

    public int GetCapacity() {
        return capacity;
    }
}
