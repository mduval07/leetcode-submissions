public class DynamicArray {
    
    private int size;
    private int[] myArray;

    public DynamicArray(int capacity) {
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
         var newArray = new int[myArray.Length * 2];     
         Array.Copy(myArray, newArray, size);
        // for (int i = 0; i < size; i++)
        // {
        //     newArray[i] = myArray[i];
        // }        
        myArray = newArray;    
    }

    public int GetSize() {
         return size;
    }

    public int GetCapacity() {
        return myArray.Length;
    }
}
