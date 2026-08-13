/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    // [0,1,2,3]
    public ListNode ReverseList(ListNode head) {
        
        var curr = head;
        ListNode previous = null;

        while (curr != null)
        {
            ListNode temp = curr.next;
            curr.next = previous;
            previous = curr;
            curr = temp;
        }

        return previous;
    }
}
