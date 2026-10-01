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
    public void ReorderList(ListNode head) {
        if(head == null)
        {
            return;
        }

        var slow = head;
        var fast = head;

        while(fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        var second = slow.next;
        slow.next = null;      


        ListNode prev = null;
        while(second != null)
        {
            var next = second.next;
            second.next = prev;
            prev = second;
            second = next;
        }        


        while(prev != null)
        {
            var nextFirst = head.next;
            var nextSecond = prev.next;
            
            head.next = prev;
            prev.next = nextFirst;

            head = nextFirst;
            prev = nextSecond;
        }

    }
}
