public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class LinkedList {
    
    private ListNode head;
    private ListNode tail;

    public LinkedList() {
        head = new ListNode(-1);
        tail = head;
    }

    public int Get(int index) {
        var node = head.next;
        int i = 0;
        while (node != null)
        {
            if (i == index)
            {
                return node.val;
            }
            node = node.next;
            i++;
        }

        return -1;
    }

    public void InsertHead(int val) {
        
        var newHead = new ListNode(val, head.next);
        head.next = newHead;
        if (newHead.next == null)
            tail = newHead;
    }

    public void InsertTail(int val) {

        var newTail = new ListNode(val);
        tail.next = newTail;
        tail = newTail;
    }

    public bool Remove(int index) {
        int i = 0;
        ListNode curr = this.head;
         while (i < index && curr != null) {
            i++;
            curr = curr.next;
        }

        // Remove the node ahead of curr
        if (curr != null && curr.next != null) {
            if (curr.next == this.tail) {
                this.tail = curr;
            }
            curr.next = curr.next.next;
            return true;
        }
        return false;
    }

    public List<int> GetValues() {

        var returnVal = new List<int>();

        var node = head.next;
        while (node != null)
        {
            returnVal.Add(node.val);
            node = node.next;
        }

        return returnVal;

    }
}